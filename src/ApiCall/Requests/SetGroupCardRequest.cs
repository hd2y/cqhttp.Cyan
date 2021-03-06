using cqhttp.Cyan.ApiCall.Requests.Base;

namespace cqhttp.Cyan.ApiCall.Requests {
    /// <summary></summary>
    public class SetGroupCardRequest : SetGroupMemberStatusRequest {
        string card;
        /// <param name="group_id"></param>
        /// <param name="user_id"></param>
        /// <param name="card">设置的群名片</param>
        /// <param name="isRateLimited">是否为限速调用</param>
        public SetGroupCardRequest (
                long group_id, long user_id,
                string card, bool isRateLimited = false):
            base ("/set_group_card", group_id, user_id, isRateLimited) {
                this.response = new Results.EmptyResult ();
                this.card = card;
            }
        /// <summary></summary>
        override public string content {
            get {
                return $"{{\"group_id\":{group_id},"+
                    $"\"user_id\":{user_id},"+
                    $"\"card\":\"{Config.asJsonStringVariable(card)}\"}}";
            }
        }
    }
}