using CMMI.Store.Base;
using CMMI.Store.Contracts;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CMMI.Services
{
    public class Service
    {
        protected IDataStore Store { get; set; }
        public Service(IDataStore store)
        {
            this.Store = store;
        }

        private string GetResourceName(string templateName, string callingMethodName)
        {
            var className = this.GetType().Name;
            className = className.Replace("Service", string.Empty);
            string resourcePath = null;
            if (templateName != null)
            {
                resourcePath = $"{className}.{callingMethodName}_{templateName}.sql";

            }
            else
            {
                resourcePath = $"{className}.{callingMethodName}.sql";
            }
            return resourcePath;
        }

        protected async Task<string> GetQueryAsync(string templateName = null, [CallerMemberName]string callingMethodName = "")
        {
            string resourcePath = this.GetResourceName(templateName, callingMethodName);
            string key = "Store.Restaurant";
            var assembly = typeof(DataStore).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream(key);
            using (stream)
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = await reader.ReadToEndAsync();
                    return result;
                }
            }
        }
            
        //protected async Task<string> GetTaskAsync(string templateName = null, [CallerMemberName]string callingMethodName = "" )
        //{
        //    string resourcePath = this.get

        //}
    }
}
