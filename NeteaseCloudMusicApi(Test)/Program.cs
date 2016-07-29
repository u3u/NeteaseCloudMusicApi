/**
 * @auther u3u
 * @version 1.0.0
 * @update 2016/07/29
 * @description 推荐使用VS2015 .NET Framework 4.5 以上
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicApi
{
    class Program
    {
        static void Main( string [ ] args )
        {
            // API 测试入口
            // 验证方式：设置断点查看返回的JSON是否正确即可

            string json = string.Empty;

            // 搜索API
            json = MusicAPI.Search( "执迷" , 5 );
            // 歌曲详情API
            json = MusicAPI.Detail( "29775505" , "300587" );
            // 歌词API
            json = MusicAPI.Lyric( "29775505" );
            // 歌单信息API
            json = MusicAPI.PlayList( "374737848" );
            // MV API
            json = MusicAPI.MV( "5309397" );
        }
    }
}
