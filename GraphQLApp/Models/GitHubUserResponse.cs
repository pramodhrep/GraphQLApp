using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GraphQLApp;

namespace GraphQLApp
{

    public class Film
    {
        public string title { get; set; }
        public string director { get; set; }
    }
}