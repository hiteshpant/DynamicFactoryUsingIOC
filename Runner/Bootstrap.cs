using System;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using Contract;

namespace Runner
{
    public class Bootstrap
    {
        private readonly CompositionContainer _container;

        [ImportMany]
        public IEnumerable<ISumOfMultipleStrategy> SumOfMultiplePlugins { get; private set; }

        [ImportMany]
        public IEnumerable<IPrintSequenceStrategy> SequenceAlgoPlugins { get; private set; }

        internal Bootstrap()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();

            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new DirectoryCatalog(".","*.dll"));


            //Create the CompositionContainer with the parts in the catalog
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
    }
}
