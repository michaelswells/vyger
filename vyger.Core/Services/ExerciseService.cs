using System.Collections.Generic;
using Augment;
using Augment.Caching;
using vyger.Core;
using vyger.Core.Models;
using vyger.Core.Repositories;

namespace vyger.Core.Services
{
    #region Service interface

    /// <summary>
    /// Service Interface for Exercise
    /// </summary>
    public interface IExerciseService
    {
        /// <summary>
        ///
        /// </summary>
        ExerciseCollection GetExercises();

        /// <summary>
        ///
        /// </summary>
        void AddExercise(Exercise exercise);

        /// <summary>
        ///
        /// </summary>
        void UpdateExercise(string id, Exercise overlay);
    }

    #endregion

    /// <summary>
    /// Service Implementation for Exercise
    /// </summary>
    public class ExerciseService : IExerciseService
    {
        #region Members

        private IExerciseGroupService _groups;
        private IExerciseCategoryService _categories;
        private ISecurityActor _actor;
        private IExerciseRepository _repository;
        private ICacheManager _cache;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance
        /// </summary>
        public ExerciseService(
            IExerciseGroupService groups,
            IExerciseCategoryService categories,
            ISecurityActor actor,
            IExerciseRepository repository,
            ICacheManager cache)
        {
            _groups = groups;
            _categories = categories;
            _actor = actor;
            _repository = repository;
            _cache = cache;
        }

        #endregion

        #region Methods

        /// <summary>
        ///
        /// </summary>
        public ExerciseCollection GetExercises()
        {
            ExerciseCollection exercises = _cache
                .Cache(() => BuildExerciseCollection())
                .By("Actor", _actor.Email)
                .DurationOf(5.Minutes())
                .CachedObject;

            return exercises;
        }

        /// <summary>
        ///
        /// </summary>
        public ExerciseCollection BuildExerciseCollection()
        {
            ExerciseGroupCollection groups = _groups.GetExerciseGroups();

            ExerciseCategoryCollection categories = _categories.GetExerciseCategories();

            IEnumerable<Exercise> exercises = _repository.GetExercises();

            return new ExerciseCollection(groups, categories, exercises);
        }

        /// <summary>
        ///
        /// </summary>
        public void AddExercise(Exercise add)
        {
            ExerciseCollection exercises = GetExercises();

            exercises.Add(add);

            _repository.SaveExercises(exercises);
        }

        /// <summary>
        ///
        /// </summary>
        public void UpdateExercise(string id, Exercise overlay)
        {
            ExerciseCollection exercises = GetExercises();

            Exercise exercise = exercises.GetByPrimaryKey(overlay.Id);

            exercise.OverlayWith(overlay);

            _repository.SaveExercises(exercises);
        }

        #endregion
    }
}