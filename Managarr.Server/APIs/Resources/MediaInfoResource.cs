using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Managarr.Server.APIs.Resources
{
    /// <summary>
    /// MediaInfoResource
    /// </summary>
    [DataContract]
    public partial class MediaInfoResource : IEquatable<MediaInfoResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaInfoResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="audioBitrate">audioBitrate.</param>
        /// <param name="audioChannels">audioChannels.</param>
        /// <param name="audioCodec">audioCodec.</param>
        /// <param name="audioLanguages">audioLanguages.</param>
        /// <param name="audioStreamCount">audioStreamCount.</param>
        /// <param name="videoBitDepth">videoBitDepth.</param>
        /// <param name="videoBitrate">videoBitrate.</param>
        /// <param name="videoCodec">videoCodec.</param>
        /// <param name="videoFps">videoFps.</param>
        /// <param name="videoDynamicRange">videoDynamicRange.</param>
        /// <param name="videoDynamicRangeType">videoDynamicRangeType.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="runTime">runTime.</param>
        /// <param name="scanType">scanType.</param>
        /// <param name="subtitles">subtitles.</param>
        public MediaInfoResource(int? id = default, long? audioBitrate = default, double? audioChannels = default, string audioCodec = default, string audioLanguages = default, int? audioStreamCount = default, int? videoBitDepth = default, long? videoBitrate = default, string videoCodec = default, double? videoFps = default, string videoDynamicRange = default, string videoDynamicRangeType = default, string resolution = default, string runTime = default, string scanType = default, string subtitles = default)
        {
            Id = id;
            AudioBitrate = audioBitrate;
            AudioChannels = audioChannels;
            AudioCodec = audioCodec;
            AudioLanguages = audioLanguages;
            AudioStreamCount = audioStreamCount;
            VideoBitDepth = videoBitDepth;
            VideoBitrate = videoBitrate;
            VideoCodec = videoCodec;
            VideoFps = videoFps;
            VideoDynamicRange = videoDynamicRange;
            VideoDynamicRangeType = videoDynamicRangeType;
            Resolution = resolution;
            RunTime = runTime;
            ScanType = scanType;
            Subtitles = subtitles;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets AudioBitrate
        /// </summary>
        [DataMember(Name = "audioBitrate", EmitDefaultValue = false)]
        public long? AudioBitrate { get; set; }

        /// <summary>
        /// Gets or Sets AudioChannels
        /// </summary>
        [DataMember(Name = "audioChannels", EmitDefaultValue = false)]
        public double? AudioChannels { get; set; }

        /// <summary>
        /// Gets or Sets AudioCodec
        /// </summary>
        [DataMember(Name = "audioCodec", EmitDefaultValue = false)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// Gets or Sets AudioLanguages
        /// </summary>
        [DataMember(Name = "audioLanguages", EmitDefaultValue = false)]
        public string AudioLanguages { get; set; }

        /// <summary>
        /// Gets or Sets AudioStreamCount
        /// </summary>
        [DataMember(Name = "audioStreamCount", EmitDefaultValue = false)]
        public int? AudioStreamCount { get; set; }

        /// <summary>
        /// Gets or Sets VideoBitDepth
        /// </summary>
        [DataMember(Name = "videoBitDepth", EmitDefaultValue = false)]
        public int? VideoBitDepth { get; set; }

        /// <summary>
        /// Gets or Sets VideoBitrate
        /// </summary>
        [DataMember(Name = "videoBitrate", EmitDefaultValue = false)]
        public long? VideoBitrate { get; set; }

        /// <summary>
        /// Gets or Sets VideoCodec
        /// </summary>
        [DataMember(Name = "videoCodec", EmitDefaultValue = false)]
        public string VideoCodec { get; set; }

        /// <summary>
        /// Gets or Sets VideoFps
        /// </summary>
        [DataMember(Name = "videoFps", EmitDefaultValue = false)]
        public double? VideoFps { get; set; }

        /// <summary>
        /// Gets or Sets VideoDynamicRange
        /// </summary>
        [DataMember(Name = "videoDynamicRange", EmitDefaultValue = false)]
        public string VideoDynamicRange { get; set; }

        /// <summary>
        /// Gets or Sets VideoDynamicRangeType
        /// </summary>
        [DataMember(Name = "videoDynamicRangeType", EmitDefaultValue = false)]
        public string VideoDynamicRangeType { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or Sets RunTime
        /// </summary>
        [DataMember(Name = "runTime", EmitDefaultValue = false)]
        public string RunTime { get; set; }

        /// <summary>
        /// Gets or Sets ScanType
        /// </summary>
        [DataMember(Name = "scanType", EmitDefaultValue = false)]
        public string ScanType { get; set; }

        /// <summary>
        /// Gets or Sets Subtitles
        /// </summary>
        [DataMember(Name = "subtitles", EmitDefaultValue = false)]
        public string Subtitles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaInfoResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AudioBitrate: ").Append(AudioBitrate).Append("\n");
            sb.Append("  AudioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  AudioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  AudioLanguages: ").Append(AudioLanguages).Append("\n");
            sb.Append("  AudioStreamCount: ").Append(AudioStreamCount).Append("\n");
            sb.Append("  VideoBitDepth: ").Append(VideoBitDepth).Append("\n");
            sb.Append("  VideoBitrate: ").Append(VideoBitrate).Append("\n");
            sb.Append("  VideoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  VideoFps: ").Append(VideoFps).Append("\n");
            sb.Append("  VideoDynamicRange: ").Append(VideoDynamicRange).Append("\n");
            sb.Append("  VideoDynamicRangeType: ").Append(VideoDynamicRangeType).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  RunTime: ").Append(RunTime).Append("\n");
            sb.Append("  ScanType: ").Append(ScanType).Append("\n");
            sb.Append("  Subtitles: ").Append(Subtitles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as MediaInfoResource);
        }

        /// <summary>
        /// Returns true if MediaInfoResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaInfoResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaInfoResource input)
        {
            if (input == null)
                return false;

            return
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    AudioBitrate == input.AudioBitrate ||
                    AudioBitrate != null &&
                    AudioBitrate.Equals(input.AudioBitrate)
                ) &&
                (
                    AudioChannels == input.AudioChannels ||
                    AudioChannels != null &&
                    AudioChannels.Equals(input.AudioChannels)
                ) &&
                (
                    AudioCodec == input.AudioCodec ||
                    AudioCodec != null &&
                    AudioCodec.Equals(input.AudioCodec)
                ) &&
                (
                    AudioLanguages == input.AudioLanguages ||
                    AudioLanguages != null &&
                    AudioLanguages.Equals(input.AudioLanguages)
                ) &&
                (
                    AudioStreamCount == input.AudioStreamCount ||
                    AudioStreamCount != null &&
                    AudioStreamCount.Equals(input.AudioStreamCount)
                ) &&
                (
                    VideoBitDepth == input.VideoBitDepth ||
                    VideoBitDepth != null &&
                    VideoBitDepth.Equals(input.VideoBitDepth)
                ) &&
                (
                    VideoBitrate == input.VideoBitrate ||
                    VideoBitrate != null &&
                    VideoBitrate.Equals(input.VideoBitrate)
                ) &&
                (
                    VideoCodec == input.VideoCodec ||
                    VideoCodec != null &&
                    VideoCodec.Equals(input.VideoCodec)
                ) &&
                (
                    VideoFps == input.VideoFps ||
                    VideoFps != null &&
                    VideoFps.Equals(input.VideoFps)
                ) &&
                (
                    VideoDynamicRange == input.VideoDynamicRange ||
                    VideoDynamicRange != null &&
                    VideoDynamicRange.Equals(input.VideoDynamicRange)
                ) &&
                (
                    VideoDynamicRangeType == input.VideoDynamicRangeType ||
                    VideoDynamicRangeType != null &&
                    VideoDynamicRangeType.Equals(input.VideoDynamicRangeType)
                ) &&
                (
                    Resolution == input.Resolution ||
                    Resolution != null &&
                    Resolution.Equals(input.Resolution)
                ) &&
                (
                    RunTime == input.RunTime ||
                    RunTime != null &&
                    RunTime.Equals(input.RunTime)
                ) &&
                (
                    ScanType == input.ScanType ||
                    ScanType != null &&
                    ScanType.Equals(input.ScanType)
                ) &&
                (
                    Subtitles == input.Subtitles ||
                    Subtitles != null &&
                    Subtitles.Equals(input.Subtitles)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (AudioBitrate != null)
                    hashCode = hashCode * 59 + AudioBitrate.GetHashCode();
                if (AudioChannels != null)
                    hashCode = hashCode * 59 + AudioChannels.GetHashCode();
                if (AudioCodec != null)
                    hashCode = hashCode * 59 + AudioCodec.GetHashCode();
                if (AudioLanguages != null)
                    hashCode = hashCode * 59 + AudioLanguages.GetHashCode();
                if (AudioStreamCount != null)
                    hashCode = hashCode * 59 + AudioStreamCount.GetHashCode();
                if (VideoBitDepth != null)
                    hashCode = hashCode * 59 + VideoBitDepth.GetHashCode();
                if (VideoBitrate != null)
                    hashCode = hashCode * 59 + VideoBitrate.GetHashCode();
                if (VideoCodec != null)
                    hashCode = hashCode * 59 + VideoCodec.GetHashCode();
                if (VideoFps != null)
                    hashCode = hashCode * 59 + VideoFps.GetHashCode();
                if (VideoDynamicRange != null)
                    hashCode = hashCode * 59 + VideoDynamicRange.GetHashCode();
                if (VideoDynamicRangeType != null)
                    hashCode = hashCode * 59 + VideoDynamicRangeType.GetHashCode();
                if (Resolution != null)
                    hashCode = hashCode * 59 + Resolution.GetHashCode();
                if (RunTime != null)
                    hashCode = hashCode * 59 + RunTime.GetHashCode();
                if (ScanType != null)
                    hashCode = hashCode * 59 + ScanType.GetHashCode();
                if (Subtitles != null)
                    hashCode = hashCode * 59 + Subtitles.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
