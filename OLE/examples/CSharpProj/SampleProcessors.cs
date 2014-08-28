using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoksimClient
{
    /// <summary>
    /// Contains some sample methods for processing more complex data
    /// </summary>
    public static class SampleProcessors
    {
        /// <summary>
        /// Sample Code to process Zugsicherungs-Information
        /// Code is not optimized (many splits), but Zugsicherungs-Information should only be processed once at simulation start
        /// so this is not a real issue
        /// </summary>
        /// <param name="zugsicherung">Value returned by OLE-Variable "LOK.COMMON.ZUGSICHERUNGSSYSTEME"</param>
        public static void ProcessZugsicherung(string zugsicherung)
        {
            var parts = zugsicherung.Split(';');
            foreach(var p in parts)
            {
                var innerParts = p.Split(',');
                if (innerParts.Length > 0 && innerParts[0] == "PZB90")
                {
                    // PZB90
                    foreach(var i in innerParts)
                    {
                        if (i.Length > 0 && i[0] == 'V')
                        {
                            // i = Version of PZB90
                            float version = float.Parse(i.Substring(1));
                            // version now contains version of used PZB90
                            // i.e. 1.5, 1.6 or 2.0
                        }
                    }
                }
                // ...
                // important: Never assume any ordering of the returned parts of spitting the string at ';'
            }
        }
    }
}
