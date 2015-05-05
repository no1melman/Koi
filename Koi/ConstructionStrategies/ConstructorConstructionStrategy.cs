﻿namespace Koi.ConstructionStrategies
{
    using System;

    /// <summary>
    /// The constructor construction strategy.
    /// </summary>
    internal class FactoryConstructionStrategy : IConstructionStrategy
    {
        /// <summary>
        /// The factory func.
        /// </summary>
        private Func<object> factoryFunc;

        /// <summary>
        /// The set factory function.
        /// </summary>
        /// <param name="factoryFunc">
        /// The factory func.
        /// </param>
        public void SetFactoryFunction(Func<object> factoryFunc)
        {
            this.factoryFunc = factoryFunc;
        }

        /// <summary>
        /// The construct type.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object ConstructType()
        {
            return this.factoryFunc();
        }

        /// <summary>
        /// The can handle.
        /// </summary>
        /// <param name="initialisationStrategy">
        /// The initialisation strategy.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CanHandle(InitialisationStrategy initialisationStrategy)
        {
            return initialisationStrategy == InitialisationStrategy.FactoryControlled;
        }
    }
}
