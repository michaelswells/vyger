import { Injectable } from '@angular/core';

import { DataRepository } from 'src/services/data.repository';
import { FileInfo } from 'src/models/file-info';
import { LogExercise } from 'src/models/log-exercise';

@Injectable({
    providedIn: 'root'
})
export class LogsRepository
{
    private file: FileInfo;
    private logs: LogExercise[];

    constructor(
        private dataRepository: DataRepository) { }

    async getLogs(): Promise<LogExercise[]>
    {
        if (this.logs == null)
        {
            this.file = await this.dataRepository.getFile('logs.json');

            if (this.file.contents && this.file.contents.length > 0)
            {
                let parsed = <LogExercise[]>JSON.parse(this.file.contents);

                this.logs = parsed.map(x => new LogExercise(x));
            }
            else
            {
                this.logs = [];

                await this.save();
            }
        }

        return Promise.resolve(this.logs);
    }

    async getLogsFor(ymd: string): Promise<LogExercise[]>
    {
        return this
            .getLogs()
            .then(logs =>
            {
                let subset = logs.filter(x => x.ymd == ymd);

                return subset;
            });
    }

    async getLogFor(ymd: string, id: string): Promise<LogExercise>
    {
        return this
            .getLogs()
            .then(logs =>
            {
                let subset = logs.filter(x => x.ymd == ymd && x.id == id);

                if (subset && subset.length == 1)
                {
                    return subset[0];
                }
                return null;
            });
    }

    add(log: LogExercise): Promise<any>
    {
        this.logs.push(log);

        return this.save();
    }

    async save(): Promise<any>
    {
        this.file.contents = JSON.stringify(this.logs);

        return this.dataRepository.saveFile(this.file);
    }
}
