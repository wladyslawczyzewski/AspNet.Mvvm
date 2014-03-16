using System.Web;

namespace AspNet.Mvvm
{
    public class MvvmApplication : HttpApplication
    {
        #region Fields
        private MvvmAppConfiguration configuration;
        #endregion

        #region Properties
        public MvvmAppConfiguration Configuraiton
        {
            get
            {
                if (configuration == null)
                {
                    configuration = new MvvmAppConfiguration(null);
                }

                return configuration;
            }
        }
        #endregion
    }
}
