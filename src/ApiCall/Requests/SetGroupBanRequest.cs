using cqhttp.Cyan.ApiCall.Requests.Base;

namespace cqhttp.Cyan.ApiCall.Requests {
    /// <summary>
    /// 堵上一个用户的嘴
    /// </summary>
    public class SetGroupBanRequest : SetGroupMemberStatusRequest {
        long duration;
        /// <param name="group_id">群号</param>
        /// <param name="user_id">用户QQ</param>
        /// <param name="duration">禁言时长</param>
        /// <param name="isRateLimited">是否为限速调用</param>
        public SetGroupBanRequest (long group_id, long user_id, long duration, bool isRateLimited = false):
            base ("/set_group_ban", group_id, user_id, isRateLimited) {
                this.response = new Results.EmptyResult ();
                this.duration = duration;
            }
        /// <summary></summary>
        override public string content {
            get {
                return $"{{\"group_id\":{group_id},"+
                    $"\"user_id\":{user_id},"+
                    $"\"duration\":{duration}}}";
            }
        }
    }
}