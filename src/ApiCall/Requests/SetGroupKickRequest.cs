using cqhttp.Cyan.ApiCall.Requests.Base;

namespace cqhttp.Cyan.ApiCall.Requests {
    /// <summary>
    /// 群组踢人
    /// </summary>
    public class SetGroupKickRequest : SetGroupMemberStatusRequest {
        bool reject_add_request;
        /// <param name="group_id">群号码</param>
        /// <param name="user_id">要踢的用户QQ号</param>
        /// <param name="reject_add_request">是否拒绝加群请求</param>
        /// <param name="isRateLimited">是否为限速调用</param>
        /// <remark>注意此处的isAsync指的是酷Q端的异步！</remark>
        public SetGroupKickRequest (long group_id, long user_id, bool reject_add_request = false, bool isRateLimited = false):
            base ("/set_group_kick", group_id, user_id, isRateLimited) {
                this.response = new Results.EmptyResult ();
                this.group_id = group_id;
                this.user_id = user_id;
                this.reject_add_request = reject_add_request;
            }
        /// <summary></summary>
        override public string content {
            get {
                return $"{{\"group_id\":{group_id},\"user_id\":{user_id},\"reject_add_request\":{reject_add_request}}}";;
            }
        }
    }
}