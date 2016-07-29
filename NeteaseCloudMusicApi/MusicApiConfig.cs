/**
 * @auther u3u
 * @version 1.0.0
 * @update 2016/07/29
 * @description 推荐使用VS2015 .NET Framework 4.5 以上
 */

namespace NeteaseCloudMusicApi
{
    /// <summary>
    /// 网易云音乐API配置列表
    /// </summary>
    public static class MusicApiConfig
    {
        public class Search : RequestData
        {
            public override string Url { get; } = "http://music.163.com/api/search/get";
            public override string Method { get; set; } = "POST";
        }

        public class Detail : RequestData
        {
            public override string Url { get; } = "http://music.163.com/api/song/detail";
            public override string Method { get; set; } = "GET";
        }

        public class Lyric : RequestData
        {
            public override string Url { get; } = "http://music.163.com/api/song/lyric";
            public override string Method { get; set; } = "GET";
        }

        public class PlayList : RequestData
        {
            public override string Url { get; } = "http://music.163.com/api/playlist/detail";
            public override string Method { get; set; } = "GET";
        }

        public class MV : RequestData
        {
            public override string Url { get; } = "http://music.163.com/api/mv/detail";
            public override string Method { get; set; } = "GET";
        }
    }
}
