using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Implementations;

namespace Plugin.MediaManager
{
    /// <summary>
    ///     Implementation for MediaManager
    /// </summary>
    public class MediaManagerImplementation : MediaManagerBase
    {
        public MediaManagerImplementation()
        {
            Init();
        }
        public override IAudioPlayer AudioPlayer { get; set; } = new AudioPlayerImplementation();
        public override IVideoPlayer VideoPlayer { get; set; }
        public override IMediaQueue MediaQueue { get; set; }
        public override IMediaNotificationManager MediaNotificationManager { get; set; }
        public override IMediaExtractor MediaExtractor { get; set; }
    }
}