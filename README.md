# NeteaseCloudMusicApi (C#, WebAPI)
**非常感谢 [@AxHello](https://github.com/axhello) 提供 [PHP版本](https://github.com/axhello/NeteaseCloudMusicApi) 的 NeteaseCloudMusicApi**

搜集到以下可用API：

1. **搜索API**
  - 请求地址(raw): http://music.163.com/api/search/get
  - 请求地址(demo): http://y.dskui.com/api/music/search
  - 请求参数:
    - <code>s:</code> 搜索关键字
    - <code>limit:</code> 返回的条数(默认30)
    - <code>offset:</code> 偏移量,用于分页(默认0)
    - <code>type:</code> 类型(默认1)
      [1 单曲] [10 专辑] [100 歌手] [1000 歌单] [1002 用户]
  - 请求示例: 
  ``` Javascript
    $.get('http://y.dskui.com/api/music/search?s=%E6%89%A7%E8%BF%B7').then(json => console.info(json));
  ```
  
2. **歌曲详情API**
  - 请求地址(raw): http://music.163.com/api/song/detail
  - 请求地址(demo): http://y.dskui.com/api/music/detail
  - 请求参数:
    - <code>ids:</code> 要获取的歌曲id列表, 多个之间以英文逗号分隔, 例如: [29775505, 29775506]
  - 请求示例:
  ``` Javascript
    $.get('http://y.dskui.com/api/music/detail?ids=29775505,29775506').then(json => console.info(json));
  ```
  
3. **歌词API**
  - 请求地址(raw): http://music.163.com/api/song/lyric
  - 请求地址(demo): http://y.dskui.com/api/music/lyric
  - 请求参数:
    - <code>id:</code> 要获取的歌曲id
  - 根据JSON判断是否有歌词，nolyric表示无歌词，uncollected表示暂时无人提交歌词
  - 请求示例:
  ``` Javascript
    $.get('http://y.dskui.com/api/music/lyric?id=29775505').then(json => console.info(json));
  ```
  
4. **用户歌单API**
  - 请求地址(raw): http://music.163.com/api/playlist/detail
  - 请求地址(demo): http://y.dskui.com/api/music/playlist
  - 请求参数:
    - <code>id:</code> 用户歌单id
  - 请求示例:
  ``` Javascript
    $.get('http://y.dskui.com/api/music/playlist?id=374755836').then(json => console.info(json));
  ```

5. **MV视频API**
  - 请求地址(raw): http://music.163.com/api/mv/detail
  - 请求地址(demo): http://y.dskui.com/api/music/mv
  - 请求参数:
    - <code>id:</code> mvid
  - 请求示例:
  ``` Javascript
    $.get('http://y.dskui.com/api/music/mv?id=333042').then(json => console.info(json));
  ```

API返回的是json对象，前端可用js输出。

## License
#### [MIT License](https://github.com/u3u/NeteaseCloudMusicApi/blob/master/LICENSE)
