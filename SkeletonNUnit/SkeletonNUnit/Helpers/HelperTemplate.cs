using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkeletonNUnit.Managers;

namespace SkeletonNUnit.Helpers
{
    public class HelperTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelperTemplate"/> class.
        /// </summary>
        /// <param name="app">
        /// The app.
        /// </param>
        protected HelperTemplate(ApplicationManager app)
        {
            this.App = app;
        }

        /// <summary>
        /// Gets app. manager
        /// </summary>
        public ApplicationManager App { get; }
    }
}
