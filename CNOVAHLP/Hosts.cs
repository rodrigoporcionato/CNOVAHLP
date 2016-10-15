using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Management;
using Microsoft.Web.Administration;

namespace CNOVAHLP
{


    public static class ApplicationPools {

        public static List<string> GetListAppPools()
        {
            List<string> list = new List<string>();
            //1 -Necessário habilitar seu usuário no IIS como musuário anonimo.
            //2 -necessário habilitar permissões em %SystemRoot%\System32\inetsrv\config

            using (var serverManager = new ServerManager())
            {
                var apps = (from site in serverManager.Sites
                            from app in site.Applications
                            //where app.ApplicationPoolName.Equals("DefaultAppPool")
                            select app);
                apps.ToList().ForEach(a => list.Add(string.Format("{0}|{1}", a.ApplicationPoolName, a.Path)));
            }
            return list;
        }

        /// <summary>
        /// Recycle an application pool
        /// </summary>
        /// <param name="IIsApplicationPool"></param>
        public static void RecycleAppPool(string IIsApplicationPool)
        {
            ManagementScope scope = new ManagementScope(@"\\localhost\root\MicrosoftIISv2");
            scope.Connect();
            ManagementObject appPool = new ManagementObject(scope, new ManagementPath("IIsApplicationPool.Name='W3SVC/AppPools/" + IIsApplicationPool + "'"), null);
            appPool.InvokeMethod("Recycle", null, null);
        }
    }
    public class Hosts
    {
        public string HostName { get; set; }
        public string IP { get; set; }

        public List<Hosts> HostList(Sites site) {

            switch (site)
            {
                case Sites.extra:
                    return new List<Hosts> {
                        new Hosts() {  HostName="www.extra.com.br", IP="9.9.9.1"},
                        new Hosts() {  HostName="carrinho.extra.com.br", IP="127.0.0.1"}
                    };                    
                case Sites.pontofrio:
                    return new List<Hosts> {
                        new Hosts() {  HostName="www.pontofrio.com.br", IP="127.0.0.1"},
                        new Hosts() {  HostName="carrinho.pontofrio.com.br", IP="127.0.0.1"}
                    };
                case Sites.barateiro:
                    return new List<Hosts> {
                        new Hosts() {  HostName="www.barateiro.com.br", IP="127.0.0.1"},
                        new Hosts() {  HostName="carrinho.barateiro.com.br", IP="127.0.0.1"}
                    };
                case Sites.casasbahia:
                    return new List<Hosts> {
                        new Hosts() {  HostName="www.casasbahia.com.br", IP="127.0.0.1"},
                        new Hosts() {  HostName="carrinho.casasbahia.com.br", IP="127.0.0.1"}
                    };
                default:
                    break;
            }
            return new List<Hosts>();
        }
    }

    public enum Sites
    {
        extra,
        pontofrio,
        barateiro,
        casasbahia
    }
}
