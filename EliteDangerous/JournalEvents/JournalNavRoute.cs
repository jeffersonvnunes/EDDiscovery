﻿/*
 * Copyright © 2016-2018 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 *
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace EliteDangerousCore.JournalEvents
{
    [JournalEntryType(JournalTypeEnum.NavRoute)]
    public class JournalNavRoute : JournalEntry, IAdditionalFiles
    {
        public JournalNavRoute(JObject evt) : base(evt, JournalTypeEnum.NavRoute)
        {
            Rescan(evt);
        }

        private void Rescan(JObject evt)
        {
            var route = evt["Route"] as JArray;

            if (route != null)
            {
                var routeents = new List<NavRouteEntry>();

                foreach (JObject jo in route)
                {
                    var starsys = jo["StarSystem"];
                    var sysaddr = jo["SystemAddress"];
                    var starpos = new EMK.LightGeometry.Vector3(
                        jo["StarPos"][0].Float(),
                        jo["StarPos"][1].Float(),
                        jo["StarPos"][2].Float()
                    );
                    var starclass = jo["StarClass"].Str();

                    if (sysaddr == null)
                    {
                        routeents.Add(new NavRouteEntry
                        {
                            SystemAddress = starsys.Long(),
                            StarPos = starpos,
                            StarClass = starclass
                        });

                    }
                    else
                    {
                        routeents.Add(new NavRouteEntry
                        {
                            StarSystem = starsys.Str(),
                            SystemAddress = sysaddr.Long(),
                            StarPos = starpos,
                            StarClass = starclass
                        });
                    }
                }

                Route = routeents.ToArray();
            }
        }

        public NavRouteEntry[] Route { get; set; }

        public bool ReadAdditionalFiles(string directory, bool inhistoryparse, ref JObject jo)
        {
            if (Route == null)
            {
                JObject jnew = ReadAdditionalFile(System.IO.Path.Combine(directory, "NavRoute.json"), waitforfile: !inhistoryparse, checktimestamptype: true);  // check timestamp..
                if (jnew != null)        // new json, rescan. returns null if cargo in the folder is not related to this entry by time.
                {
                    jo = jnew;      // replace current
                    Rescan(jo);
                }
                return jnew != null;
            }
            else
            {
                return true;
            }
        }

        public override void FillInformation(out string info, out string detailed)
        {
            info = "Nav Route";
            detailed = $"{Route?.Length ?? 0} jumps";
        }

        public class NavRouteEntry
        {
            public string StarSystem { get; set; }
            public long SystemAddress { get; set; }
            public EMK.LightGeometry.Vector3 StarPos { get; set; }
            public string StarClass { get; set; }
        }
    }
}
