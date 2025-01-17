using Newtonsoft.Json;

namespace Confiti.MoySklad.Remap.Models
{
    /// <summary>
    /// Represents a API error.
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <remarks>
        /// If the field contains nothing, see the HTTP status code.
        /// </remarks>
        /// <value>The error code.</value>
        [JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets the column(in request body) on which the error occurred.
        /// </summary>
        /// <value>The column(in request body) on which the error occurred.</value>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// Gets or sets the error title.
        /// </summary>
        /// <value>The error title.</value>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the line(in request body) on which the error occurred.
        /// </summary>
        /// <value>The line(in request body) on which the error occurred.</value>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// Gets or sets the link to the full description of the error.
        /// </summary>
        /// <value>The link to the full description of the error.</value>
        [JsonProperty("moreInfo")]
        public string MoreInfo { get; set; }

        /// <summary>
        /// Gets or sets the parameter on which the error occurred.
        /// </summary>
        /// <value>The parameter on which the error occurred.</value>
        [JsonProperty("parameter")]
        public string Parameter { get; set; }
    }
}