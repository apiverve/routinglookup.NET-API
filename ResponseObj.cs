using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("routing_number")]
    public string routingnumber { get; set; }

    [JsonProperty("office_code")]
    public string officecode { get; set; }

    [JsonProperty("record_type_code")]
    public string recordtypecode { get; set; }

    [JsonProperty("new_routing_number")]
    public string newroutingnumber { get; set; }

    [JsonProperty("bank")]
    public string bank { get; set; }

    [JsonProperty("address")]
    public string address { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("zip")]
    public string zip { get; set; }

    [JsonProperty("zip_extension")]
    public string zipextension { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
