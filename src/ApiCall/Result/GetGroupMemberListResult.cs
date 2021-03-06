using Newtonsoft.Json.Linq;

namespace cqhttp.Cyan.ApiCall.Results {
    ///
    public class GetGroupMemberListResult : Base.ApiResult {
        /// <summary>
        /// 群成员信息列表，不准确，仅供参考
        /// </summary>
        /// <value></value>
        public Utils.GroupMemberInfo[] memberInfo { get; private set; }
        ///
        public override void Parse (string result) {
            var i = PreCheck (result);
            memberInfo = (i.raw_data as JArray).ToObject<Utils.GroupMemberInfo[]> ();
        }
    }
}