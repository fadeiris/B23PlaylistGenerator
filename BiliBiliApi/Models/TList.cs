using BilibiliApi.Models.VideoZone.AD;
using BilibiliApi.Models.VideoZone.Animal;
using BilibiliApi.Models.VideoZone.Anime;
using BilibiliApi.Models.VideoZone.Car;
using BilibiliApi.Models.VideoZone.Cinephile;
using BilibiliApi.Models.VideoZone.Dance;
using BilibiliApi.Models.VideoZone.Documentary;
using BilibiliApi.Models.VideoZone.Douga;
using BilibiliApi.Models.VideoZone.Ent;
using BilibiliApi.Models.VideoZone.Fashion;
using BilibiliApi.Models.VideoZone.Food;
using BilibiliApi.Models.VideoZone.Game;
using BilibiliApi.Models.VideoZone.GuoChuang;
using BilibiliApi.Models.VideoZone.Information;
using BilibiliApi.Models.VideoZone.Kichiku;
using BilibiliApi.Models.VideoZone.Knowledge;
using BilibiliApi.Models.VideoZone.Life;
using BilibiliApi.Models.VideoZone.Movie;
using BilibiliApi.Models.VideoZone.Music;
using BilibiliApi.Models.VideoZone.Sports;
using BilibiliApi.Models.VideoZone.Tech;
using BilibiliApi.Models.VideoZone.TV;
using System.Text.Json.Serialization;

namespace BilibiliApi.Models;

/// <summary>
/// TList
/// </summary>
public class TList
{
    #region 動畫

    /// <summary>
    /// 動畫（主分區）(douga)
    /// </summary>
    [JsonPropertyName("1")]
    public Tag1? Tag1 { get; set; }

    /// <summary>
    /// 動畫 -> MAD、AMV (mad)
    /// </summary>
    [JsonPropertyName("24")]
    public Tag24? Tag24 { get; set; }

    /// <summary>
    /// 動畫 -> MMD、3D (mmd)
    /// </summary>
    [JsonPropertyName("25")]
    public Tag25? Tag25 { get; set; }

    /// <summary>
    /// 動畫 -> 短片、手書、配音 (voice)
    /// </summary>
    [JsonPropertyName("47")]
    public Tag47? Tag47 { get; set; }

    /// <summary>
    /// 動畫 -> 手辦、模玩 (garage_kit)
    /// </summary>
    [JsonPropertyName("210")]
    public Tag210? Tag210 { get; set; }

    /// <summary>
    /// 動畫 -> 特攝 (tokusatsu)
    /// </summary>
    [JsonPropertyName("86")]
    public Tag86? Tag86 { get; set; }

    /// <summary>
    /// 動畫 -> 動漫雜談 (acgntalks)
    /// </summary>
    [JsonPropertyName("253")]
    public Tag253? Tag253 { get; set; }

    /// <summary>
    /// 動畫 -> 綜合 (other)
    /// </summary>
    [JsonPropertyName("27")]
    public Tag27? Tag27 { get; set; }

    #endregion

    #region 番劇

    /// <summary>
    /// 番劇（主分區）(anime)
    /// </summary>
    [JsonPropertyName("13")]
    public Tag13? Tag13 { get; set; }

    /// <summary>
    /// 番劇 -> 資訊 (information)
    /// </summary>
    [JsonPropertyName("51")]
    public Tag51? Tag51 { get; set; }

    /// <summary>
    /// 番劇 -> 官方延伸 (offical)
    /// </summary>
    [JsonPropertyName("152")]
    public Tag152? Tag152 { get; set; }

    /// <summary>
    /// 番劇 -> 完結動畫 (finish)
    /// </summary>
    [JsonPropertyName("32")]
    public Tag32? Tag32 { get; set; }

    /// <summary>
    /// 番劇 -> 連載動畫 (serial)
    /// </summary>
    [JsonPropertyName("33")]
    public Tag33? Tag33 { get; set; }

    #endregion

    #region 國創

    /// <summary>
    /// 國創（主分區）(guochuang)
    /// </summary>
    [JsonPropertyName("167")]
    public Tag167? Tag167 { get; set; }

    /// <summary>
    /// 國創 -> 國產動畫 (chinese)
    /// </summary>
    [JsonPropertyName("153")]
    public Tag153? Tag153 { get; set; }

    /// <summary>
    /// 國創 -> 國產原創相關 (original)
    /// </summary>
    [JsonPropertyName("168")]
    public Tag168? Tag168 { get; set; }

    /// <summary>
    /// 國創 -> 布袋戲 (puppetry)
    /// </summary>
    [JsonPropertyName("169")]
    public Tag169? Tag169 { get; set; }

    /// <summary>
    /// 國創 -> 資訊 (information)
    /// </summary>
    [JsonPropertyName("170")]
    public Tag170? Tag170 { get; set; }

    /// <summary>
    /// 國創 -> 動態漫、廣播劇 (motioncomic)
    /// </summary>
    [JsonPropertyName("195")]
    public Tag195? Tag195 { get; set; }

    #endregion

    #region 音樂

    /// <summary>
    /// 音樂（主分區）(music)
    /// </summary>
    [JsonPropertyName("3")]
    public Tag3? Tag3 { get; set; }

    /// <summary>
    /// 音樂 -> 原創音樂 (original)
    /// </summary>
    [JsonPropertyName("28")]
    public Tag28? Tag28 { get; set; }

    /// <summary>
    /// 音樂 -> 翻唱 (cover)
    /// </summary>
    [JsonPropertyName("31")]
    public Tag31? Tag31 { get; set; }

    /// <summary>
    /// 音樂 -> VOCALOID、UTAU (vocaloid)
    /// </summary>
    [JsonPropertyName("30")]
    public Tag30? Tag30 { get; set; }

    /// <summary>
    /// 音樂 -> 演奏 (perform)
    /// </summary>
    [JsonPropertyName("59")]
    public Tag59? Tag59 { get; set; }

    /// <summary>
    /// 音樂 -> MV (mv)
    /// </summary>
    [JsonPropertyName("193")]
    public Tag193? Tag193 { get; set; }

    /// <summary>
    /// 音樂 -> 音樂現場 (live)
    /// </summary>
    [JsonPropertyName("29")]
    public Tag29? Tag29 { get; set; }

    /// <summary>
    /// 音樂 -> 音樂綜合 (other)
    /// </summary>
    [JsonPropertyName("130")]
    public Tag130? Tag130 { get; set; }

    /// <summary>
    /// 音樂 -> 樂評盤點 (commentary)
    /// </summary>
    [JsonPropertyName("243")]
    public Tag243? Tag243 { get; set; }

    /// <summary>
    /// 音樂 -> 音樂教學 (tutorial)
    /// </summary>
    [JsonPropertyName("244")]
    public Tag244? Tag244 { get; set; }

    /// <summary>
    /// 音樂 -> 電音 (electronic)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("194")]
    public Tag194? Tag194 { get; set; }

    #endregion

    #region 舞蹈

    /// <summary>
    /// 舞蹈（主分區）(dance)
    /// </summary>
    [JsonPropertyName("129")]
    public Tag129? Tag129 { get; set; }

    /// <summary>
    /// 舞蹈 -> 宅舞 (otaku)
    /// </summary>
    [JsonPropertyName("20")]
    public Tag20? Tag20 { get; set; }

    /// <summary>
    /// 舞蹈 -> 舞蹈綜合 (three_d)
    /// </summary>
    [JsonPropertyName("154")]
    public Tag154? Tag154 { get; set; }

    /// <summary>
    /// 舞蹈 -> 舞蹈教程 (demo)
    /// </summary>
    [JsonPropertyName("156")]
    public Tag156? Tag156 { get; set; }

    /// <summary>
    /// 舞蹈 -> 街舞 (hiphop)
    /// </summary>
    [JsonPropertyName("198")]
    public Tag198? Tag198 { get; set; }

    /// <summary>
    /// 舞蹈 -> 明星舞蹈 (star)
    /// </summary>
    [JsonPropertyName("199")]
    public Tag199? Tag199 { get; set; }

    /// <summary>
    /// 舞蹈 -> 中國舞 (china)
    /// </summary>
    [JsonPropertyName("200")]
    public Tag200? Tag200 { get; set; }

    #endregion

    #region 遊戲

    /// <summary>
    /// 遊戲（主分區）(game)
    /// </summary>
    [JsonPropertyName("4")]
    public Tag4? Tag4 { get; set; }

    /// <summary>
    /// 遊戲 -> 單機遊戲 (stand_alone)
    /// </summary>
    [JsonPropertyName("17")]
    public Tag17? Tag17 { get; set; }

    /// <summary>
    /// 遊戲 -> 電子競技 (esports)
    /// </summary>
    [JsonPropertyName("171")]
    public Tag171? Tag171 { get; set; }

    /// <summary>
    /// 遊戲 -> 手機遊戲 (mobile)
    /// </summary>
    [JsonPropertyName("172")]
    public Tag172? Tag172 { get; set; }

    /// <summary>
    /// 遊戲 -> 網路遊戲 (online)
    /// </summary>
    [JsonPropertyName("65")]
    public Tag65? Tag65 { get; set; }

    /// <summary>
    /// 遊戲 -> 桌遊棋牌 (board)
    /// </summary>
    [JsonPropertyName("173")]
    public Tag173? Tag173 { get; set; }

    /// <summary>
    /// 遊戲 -> GMV (gmv)
    /// </summary>
    [JsonPropertyName("121")]
    public Tag121? Tag121 { get; set; }

    /// <summary>
    /// 遊戲 -> 音遊 (music)
    /// </summary>
    [JsonPropertyName("136")]
    public Tag136? Tag136 { get; set; }

    /// <summary>
    /// 遊戲 -> Mugen (mugen)
    /// </summary>
    [JsonPropertyName("19")]
    public Tag19? Tag19 { get; set; }

    #endregion

    #region 知識

    /// <summary>
    /// 知識（主分區）(knowledge)
    /// </summary>
    [JsonPropertyName("36")]
    public Tag36? Tag36 { get; set; }

    /// <summary>
    /// 知識 -> 科學科普 (science)
    /// </summary>
    [JsonPropertyName("201")]
    public Tag201? Tag201 { get; set; }

    /// <summary>
    /// 知識 -> 社科、法律、心理 [原設科人文、原趣味科普人文] (social_science)
    /// </summary>
    [JsonPropertyName("124")]
    public Tag124? Tag124 { get; set; }

    /// <summary>
    /// 知識 -> 人文歷史 (humanity_history)
    /// </summary>
    [JsonPropertyName("228")]
    public Tag228? Tag228 { get; set; }

    /// <summary>
    /// 知識 -> 財金商業 (business)
    /// </summary>
    [JsonPropertyName("207")]
    public Tag207? Tag207 { get; set; }

    /// <summary>
    /// 知識 -> 校園學習 (campus)
    /// </summary>
    [JsonPropertyName("208")]
    public Tag208? Tag208 { get; set; }

    /// <summary>
    /// 知識 -> 職業職場 (career)
    /// </summary>
    [JsonPropertyName("209")]
    public Tag209? Tag209 { get; set; }

    /// <summary>
    /// 知識 -> 設計、創意 (design)
    /// </summary>
    [JsonPropertyName("229")]
    public Tag229? Tag229 { get; set; }

    /// <summary>
    /// 知識 -> 野生技術協會 (skill)
    /// </summary>
    [JsonPropertyName("122")]
    public Tag122? Tag122 { get; set; }

    /// <summary>
    /// 知識 -> 演講、公開課 (speech_course)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("39")]
    public Tag39? Tag39 { get; set; }

    /// <summary>
    /// 知識 -> 星海 (military)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("96")]
    public Tag96? Tag96 { get; set; }

    /// <summary>
    /// 知識 -> 機械 (mechanical)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("98")]
    public Tag98? Tag98 { get; set; }

    #endregion

    #region 科技

    /// <summary>
    /// 科技（主分區） [原數碼分區] (tech)
    /// </summary>
    [JsonPropertyName("188")]
    public Tag188? Tag188 { get; set; }

    /// <summary>
    /// 科技 -> 數碼 [(原) 手機平板] (digital)
    /// </summary>
    [JsonPropertyName("95")]
    public Tag95? Tag95 { get; set; }

    /// <summary>
    /// 科技 -> 軟件應用 (application)
    /// </summary>
    [JsonPropertyName("230")]
    public Tag230? Tag230 { get; set; }

    /// <summary>
    /// 科技 -> 計算機技術 (computer_tech)
    /// </summary>
    [JsonPropertyName("231")]
    public Tag231? Tag231 { get; set; }

    /// <summary>
    /// 科技 -> 科工機械 [(原) 工業、工程、機械] (industry)
    /// </summary>
    [JsonPropertyName("232")]
    public Tag232? Tag232 { get; set; }

    /// <summary>
    /// 科技 -> 極客DIY (diy)
    /// </summary>
    [JsonPropertyName("233")]
    public Tag233? Tag233 { get; set; }

    /// <summary>
    /// 科技 -> 電腦裝機 (pc)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("189")]
    public Tag189? Tag189 { get; set; }

    /// <summary>
    /// 科技 -> 攝影攝像 (photography)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("190")]
    public Tag190? Tag190 { get; set; }

    /// <summary>
    /// 科技 -> 影音智能 (intelligence_av)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("191")]
    public Tag191? Tag191 { get; set; }

    #endregion

    #region 運動

    /// <summary>
    /// 運動（主分區）(sports)
    /// </summary>
    [JsonPropertyName("234")]
    public Tag234? Tag234 { get; set; }

    /// <summary>
    /// 運動 -> 籃球 (basketball)
    /// </summary>
    [JsonPropertyName("235")]
    public Tag235? Tag235 { get; set; }

    /// <summary>
    /// 運動 -> 足球 (football)
    /// </summary>
    [JsonPropertyName("249")]
    public Tag249? Tag249 { get; set; }

    /// <summary>
    /// 運動 -> 健身 (aerobics)
    /// </summary>
    [JsonPropertyName("164")]
    public Tag164? Tag164 { get; set; }

    /// <summary>
    /// 運動 -> 競技體育 (athletic)
    /// </summary>
    [JsonPropertyName("236")]
    public Tag236? Tag236 { get; set; }

    /// <summary>
    /// 運動 -> 運動文化 (culture)
    /// </summary>
    [JsonPropertyName("237")]
    public Tag237? Tag237 { get; set; }

    /// <summary>
    /// 運動 -> 綜合運動 (comprehensive)
    /// </summary>
    [JsonPropertyName("238")]
    public Tag238? Tag238 { get; set; }

    #endregion

    #region 汽車

    /// <summary>
    /// 汽車（主分區）(car)
    /// </summary>
    [JsonPropertyName("223")]
    public Tag223? Tag223 { get; set; }

    /// <summary>
    /// 汽車 -> 賽車 (racing)
    /// </summary>
    [JsonPropertyName("245")]
    public Tag245? Tag245 { get; set; }

    /// <summary>
    /// 汽車 -> 改裝玩車 (modifiedvehicle)
    /// </summary>
    [JsonPropertyName("246")]
    public Tag246? Tag246 { get; set; }

    /// <summary>
    /// 汽車 -> 新能源車 (newenergyvehicle)
    /// </summary>
    [JsonPropertyName("247")]
    public Tag247? Tag247 { get; set; }

    /// <summary>
    /// 汽車 -> 房車 (touringcar)
    /// </summary>
    [JsonPropertyName("248")]
    public Tag248? Tag248 { get; set; }

    /// <summary>
    /// 汽車 -> 摩托車 (motorcycle)
    /// </summary>
    [JsonPropertyName("240")]
    public Tag240? Tag240 { get; set; }

    /// <summary>
    /// 汽車 -> 購車攻略 (strategy)
    /// </summary>
    [JsonPropertyName("227")]
    public Tag227? Tag227 { get; set; }

    /// <summary>
    /// 汽車 -> 汽車生活 (life)
    /// </summary>
    [JsonPropertyName("176")]
    public Tag176? Tag176 { get; set; }

    /// <summary>
    /// 汽車 -> 汽車文化 (culture)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("224")]
    public Tag224? Tag224 { get; set; }

    /// <summary>
    /// 汽車 -> 汽車極客 (geek)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("225")]
    public Tag225? Tag225 { get; set; }

    /// <summary>
    /// 汽車 -> 智能出行 (smart)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("226")]
    public Tag226? Tag226 { get; set; }

    #endregion

    #region 生活

    /// <summary>
    /// 生活（主分區）(life)
    /// </summary>
    [JsonPropertyName("160")]
    public Tag160? Tag160 { get; set; }

    /// <summary>
    /// 生活 -> 搞笑 (funny)
    /// </summary>
    [JsonPropertyName("138")]
    public Tag138? Tag138 { get; set; }

    /// <summary>
    /// 生活 -> 出行 (travel)
    /// </summary>
    [JsonPropertyName("250")]
    public Tag250? Tag250 { get; set; }

    /// <summary>
    /// 生活 -> 三農 (rurallife)
    /// </summary>
    [JsonPropertyName("251")]
    public Tag251? Tag251 { get; set; }

    /// <summary>
    /// 生活 -> 家居房產 (home)
    /// </summary>
    [JsonPropertyName("239")]
    public Tag239? Tag239 { get; set; }

    /// <summary>
    /// 生活 -> 手工 (handmake)
    /// </summary>
    [JsonPropertyName("161")]
    public Tag161? Tag161 { get; set; }

    /// <summary>
    /// 生活 -> 繪畫 (painting)
    /// </summary>
    [JsonPropertyName("162")]
    public Tag162? Tag162 { get; set; }

    /// <summary>
    /// 生活 -> 日常 (daily)
    /// </summary>
    [JsonPropertyName("21")]
    public Tag21? Tag21 { get; set; }

    /// <summary>
    /// 生活 -> 其他 (other)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("174")]
    public Tag174? Tag174Old { get; set; }

    #endregion

    #region 美食

    /// <summary>
    /// 美食（主分區）(food)
    /// </summary>
    [JsonPropertyName("211")]
    public Tag211? Tag211 { get; set; }

    /// <summary>
    /// 美食 -> 美食製作 [(原)生活 -> 美食圈] (make)
    /// </summary>
    [JsonPropertyName("76")]
    public Tag76? Tag76 { get; set; }

    /// <summary>
    /// 美食 -> 美食偵探 (detective)
    /// </summary>
    [JsonPropertyName("212")]
    public Tag212? Tag212 { get; set; }

    /// <summary>
    /// 美食 -> 美食測評 (measurement)
    /// </summary>
    [JsonPropertyName("213")]
    public Tag213? Tag213 { get; set; }

    /// <summary>
    /// 美食 -> 田園美食 (rural)
    /// </summary>
    [JsonPropertyName("214")]
    public Tag214? Tag214 { get; set; }

    /// <summary>
    /// 美食 -> 美食紀錄 (record)
    /// </summary>
    [JsonPropertyName("215")]
    public Tag215? Tag215 { get; set; }

    #endregion

    #region 動物圈

    /// <summary>
    /// 動物圈（主分區）(animal)
    /// </summary>
    [JsonPropertyName("217")]
    public Tag217? Tag217 { get; set; }

    /// <summary>
    /// 動物圈 -> 喵星人 (cat)
    /// </summary>
    [JsonPropertyName("218")]
    public Tag218? Tag218 { get; set; }

    /// <summary>
    /// 動物圈 -> 汪星人 (dog)
    /// </summary>
    [JsonPropertyName("219")]
    public Tag219? Tag219 { get; set; }

    /// <summary>
    /// 動物圈 -> 大熊貓 (panda)
    /// </summary>
    [JsonPropertyName("220")]
    public Tag220? Tag220 { get; set; }

    /// <summary>
    /// 動物圈 -> 野生動物 (wild_animal)
    /// </summary>
    [JsonPropertyName("221")]
    public Tag221? Tag221 { get; set; }

    /// <summary>
    /// 動物圈 -> 爬寵 (reptiles)
    /// </summary>
    [JsonPropertyName("222")]
    public Tag222? Tag222 { get; set; }

    /// <summary>
    /// 動物圈 -> 動物綜合 (animal_composite)
    /// </summary>
    [JsonPropertyName("75")]
    public Tag75? Tag75 { get; set; }

    #endregion

    #region 鬼畜

    /// <summary>
    /// 鬼畜（主分區）(kichiku)
    /// </summary>
    [JsonPropertyName("119")]
    public Tag119? Tag119 { get; set; }

    /// <summary>
    /// 鬼畜 -> 鬼畜調教 (guide)
    /// </summary>
    [JsonPropertyName("22")]
    public Tag22? Tag22 { get; set; }

    /// <summary>
    /// 鬼畜 -> 音MAD (mad)
    /// </summary>
    [JsonPropertyName("26")]
    public Tag26? Tag26 { get; set; }

    /// <summary>
    /// 鬼畜 -> 人力VOCALOID (manual_vocaloid)
    /// </summary>
    [JsonPropertyName("126")]
    public Tag126? Tag126 { get; set; }

    /// <summary>
    /// 鬼畜 -> 鬼畜劇場 (theatre)
    /// </summary>
    [JsonPropertyName("216")]
    public Tag216? Tag216 { get; set; }

    /// <summary>
    /// 鬼畜 -> 教程演示 (course)
    /// </summary>
    [JsonPropertyName("127")]
    public Tag127? Tag127 { get; set; }

    #endregion

    #region 時尚

    /// <summary>
    /// 時尚（主分區）(fashion)
    /// </summary>
    [JsonPropertyName("155")]
    public Tag155? Tag155 { get; set; }

    /// <summary>
    /// 時尚 -> 美妝護膚 (makeup)
    /// </summary>
    [JsonPropertyName("157")]
    public Tag157? Tag157 { get; set; }

    /// <summary>
    /// 時尚 -> 仿妝cos (cos)
    /// </summary>
    [JsonPropertyName("252")]
    public Tag252? Tag252 { get; set; }

    /// <summary>
    /// 時尚 -> 穿搭 (clothing)
    /// </summary>
    [JsonPropertyName("158")]
    public Tag158? Tag158 { get; set; }

    /// <summary>
    /// 時尚 -> 時尚潮流 (catwalk)
    /// </summary>
    [JsonPropertyName("159")]
    public Tag159? Tag159 { get; set; }

    /// <summary>
    /// 時尚 -> 風尚標 (trends)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("192")]
    public Tag192? Tag192 { get; set; }

    #endregion

    #region 資訊

    /// <summary>
    /// 資訊（主分區）(information)
    /// </summary>
    [JsonPropertyName("202")]
    public Tag202? Tag202 { get; set; }

    /// <summary>
    /// 資訊 -> 熱點 (hotspot)
    /// </summary>
    [JsonPropertyName("203")]
    public Tag203? Tag203 { get; set; }

    /// <summary>
    /// 資訊 -> 環球 (global)
    /// </summary>
    [JsonPropertyName("204")]
    public Tag204? Tag204 { get; set; }

    /// <summary>
    /// 資訊 -> 社會 (social)
    /// </summary>
    [JsonPropertyName("205")]
    public Tag205? Tag205 { get; set; }

    /// <summary>
    /// 資訊 -> 綜合 (multiple)
    /// </summary>
    [JsonPropertyName("206")]
    public Tag206? Tag206 { get; set; }

    #endregion

    #region 廣告（此分區已下線）

    /// <summary>
    /// 廣告（主分區）(ad)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("165")]
    public Tag165? Tag165 { get; set; }

    /// <summary>
    /// 廣告（已下線）(ad)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("166")]
    public Tag166? Tag166 { get; set; }

    #endregion

    #region 娛樂

    /// <summary>
    /// 娛樂（主分區）(ent)
    /// </summary>
    [JsonPropertyName("5")]
    public Tag5? Tag5 { get; set; }

    /// <summary>
    /// 娛樂 -> 綜藝 (variety)
    /// </summary>
    [JsonPropertyName("71")]
    public Tag71? Tag71 { get; set; }

    /// <summary>
    /// 娛樂 -> 娛樂雜談 (talker)
    /// </summary>
    [JsonPropertyName("241")]
    public Tag241? Tag241 { get; set; }

    /// <summary>
    /// 娛樂 -> 粉絲創作 (fans)
    /// </summary>
    [JsonPropertyName("242")]
    public Tag242? Tag242 { get; set; }

    /// <summary>
    /// 娛樂 -> 明星綜合 (celebrity)
    /// </summary>
    [JsonPropertyName("137")]
    public Tag137? Tag137 { get; set; }

    /// <summary>
    /// 娛樂 -> Korea 相關 (korea)
    /// </summary>
    [Obsolete("此分區已下線")]
    [JsonPropertyName("131")]
    public Tag131? Tag131 { get; set; }

    #endregion

    #region 影視

    /// <summary>
    /// 影視（主分區）(cinephile)
    /// </summary>
    [JsonPropertyName("181")]
    public Tag181? Tag181 { get; set; }

    /// <summary>
    /// 影視 -> 影視雜談 (cinecism)
    /// </summary>
    [JsonPropertyName("182")]
    public Tag182? Tag182 { get; set; }

    /// <summary>
    /// 影視 -> 影視剪輯 (montage)
    /// </summary>
    [JsonPropertyName("183")]
    public Tag183? Tag183 { get; set; }

    /// <summary>
    /// 影視 -> 小劇場 (shortfilm)
    /// </summary>
    [JsonPropertyName("85")]
    public Tag85? Tag85 { get; set; }

    /// <summary>
    /// 影視 -> 預告、資訊 (trailer_info)
    /// </summary>
    [JsonPropertyName("184")]
    public Tag184? Tag184 { get; set; }

    #endregion

    #region 紀錄片

    /// <summary>
    /// 紀錄片（主分區）(documentary)
    /// </summary>
    [JsonPropertyName("177")]
    public Tag177? Tag177 { get; set; }

    /// <summary>
    /// 紀錄片 -> 人文、歷史 (history)
    /// </summary>
    [JsonPropertyName("37")]
    public Tag37? Tag37 { get; set; }

    /// <summary>
    /// 紀錄片 -> 科學、探索、自然 (science)
    /// </summary>
    [JsonPropertyName("178")]
    public Tag178? Tag178 { get; set; }

    /// <summary>
    /// 紀錄片 -> 軍事 (military)
    /// </summary>
    [JsonPropertyName("179")]
    public Tag179? Tag179 { get; set; }

    /// <summary>
    /// 紀錄片 -> 社會、美食、旅行 (travel)
    /// </summary>
    [JsonPropertyName("180")]
    public Tag180? Tag180 { get; set; }

    #endregion

    #region 電影

    /// <summary>
    /// 電影（主分區）(movie)
    /// </summary>
    [JsonPropertyName("23")]
    public Tag23? Tag23 { get; set; }

    /// <summary>
    /// 電影 -> 華語電影 (chinese)
    /// </summary>
    [JsonPropertyName("147")]
    public Tag147? Tag147 { get; set; }

    /// <summary>
    /// 電影 -> 歐美電影 (west)
    /// </summary>
    [JsonPropertyName("145")]
    public Tag145? Tag145 { get; set; }

    /// <summary>
    /// 電影 -> 日本電影 (japan)
    /// </summary>
    [JsonPropertyName("146")]
    public Tag146? Tag146 { get; set; }

    /// <summary>
    /// 電影 -> 其他國家 (movie)
    /// </summary>
    [JsonPropertyName("83")]
    public Tag83? Tag83 { get; set; }

    #endregion

    #region 電視劇

    /// <summary>
    /// 電視劇（主分區）(tv)
    /// </summary>
    [JsonPropertyName("11")]
    public Tag11? Tag11 { get; set; }

    /// <summary>
    /// 電視劇 -> 國產劇 (mainland)
    /// </summary>
    [JsonPropertyName("185")]
    public Tag185? Tag185 { get; set; }

    /// <summary>
    /// 電視劇 -> 海外劇 (overseas)
    /// </summary>
    [JsonPropertyName("187")]
    public Tag187? Tag187 { get; set; }

    #endregion
}