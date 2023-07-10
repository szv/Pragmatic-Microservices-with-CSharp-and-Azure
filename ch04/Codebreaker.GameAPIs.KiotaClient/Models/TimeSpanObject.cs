using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Codebreaker.Client.Models {
    public class TimeSpanObject : IParsable {
        /// <summary>The days property</summary>
        public int? Days { get; private set; }
        /// <summary>The hours property</summary>
        public int? Hours { get; private set; }
        /// <summary>The microseconds property</summary>
        public int? Microseconds { get; private set; }
        /// <summary>The milliseconds property</summary>
        public int? Milliseconds { get; private set; }
        /// <summary>The minutes property</summary>
        public int? Minutes { get; private set; }
        /// <summary>The nanoseconds property</summary>
        public int? Nanoseconds { get; private set; }
        /// <summary>The seconds property</summary>
        public int? Seconds { get; private set; }
        /// <summary>The ticks property</summary>
        public long? Ticks { get; set; }
        /// <summary>The totalDays property</summary>
        public double? TotalDays { get; private set; }
        /// <summary>The totalHours property</summary>
        public double? TotalHours { get; private set; }
        /// <summary>The totalMicroseconds property</summary>
        public double? TotalMicroseconds { get; private set; }
        /// <summary>The totalMilliseconds property</summary>
        public double? TotalMilliseconds { get; private set; }
        /// <summary>The totalMinutes property</summary>
        public double? TotalMinutes { get; private set; }
        /// <summary>The totalNanoseconds property</summary>
        public double? TotalNanoseconds { get; private set; }
        /// <summary>The totalSeconds property</summary>
        public double? TotalSeconds { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeSpanObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeSpanObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"days", n => { Days = n.GetIntValue(); } },
                {"hours", n => { Hours = n.GetIntValue(); } },
                {"microseconds", n => { Microseconds = n.GetIntValue(); } },
                {"milliseconds", n => { Milliseconds = n.GetIntValue(); } },
                {"minutes", n => { Minutes = n.GetIntValue(); } },
                {"nanoseconds", n => { Nanoseconds = n.GetIntValue(); } },
                {"seconds", n => { Seconds = n.GetIntValue(); } },
                {"ticks", n => { Ticks = n.GetLongValue(); } },
                {"totalDays", n => { TotalDays = n.GetDoubleValue(); } },
                {"totalHours", n => { TotalHours = n.GetDoubleValue(); } },
                {"totalMicroseconds", n => { TotalMicroseconds = n.GetDoubleValue(); } },
                {"totalMilliseconds", n => { TotalMilliseconds = n.GetDoubleValue(); } },
                {"totalMinutes", n => { TotalMinutes = n.GetDoubleValue(); } },
                {"totalNanoseconds", n => { TotalNanoseconds = n.GetDoubleValue(); } },
                {"totalSeconds", n => { TotalSeconds = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("ticks", Ticks);
        }
    }
}
