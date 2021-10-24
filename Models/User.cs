using System.Collections.Generic;
using System.Linq;

namespace asp_dotnet_sample_app.Models
{
    /// <summary>
    /// ユーザーモデル
    /// </summary>
    public class User
    {
        /// <summary>
        /// ユーザー名
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }

        /// <summary>
        /// 年齢
        /// </summary>
        /// <value></value>
        public int Age { get; set; }

        /// <summary>
        /// 履歴
        /// </summary>
        /// <value></value>
        public List<string> History { get; set; }

        /// <summary>
        /// 履歴をカンマ区切りの文字列で取得する
        /// </summary>
        /// <returns></returns>
        public string GetHistory()
        {
            var historyString = string.Join(",", History);

            return historyString;
        }

        /// <summary>
        /// prefixで始まる履歴の数を取得する
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public int GetHistoryCountStartWith(string prefix)
        {
            var count = History.Count(h => h.StartsWith(prefix));

            return count;
        }
    }
}
