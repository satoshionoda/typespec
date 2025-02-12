// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace Payload.MediaType
{
    public partial class StringBody
    {
        protected StringBody() => throw null;

        public ClientPipeline Pipeline => throw null;

        public virtual ClientResult SendAsText(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual Task<ClientResult> SendAsTextAsync(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual ClientResult SendAsText(string text) => throw null;

        public virtual Task<ClientResult> SendAsTextAsync(string text) => throw null;

        public virtual ClientResult GetAsText(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetAsTextAsync(RequestOptions options) => throw null;

        public virtual ClientResult<string> GetAsText() => throw null;

        public virtual Task<ClientResult<string>> GetAsTextAsync() => throw null;

        public virtual ClientResult SendAsJson(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual Task<ClientResult> SendAsJsonAsync(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual ClientResult SendAsJson(string text) => throw null;

        public virtual Task<ClientResult> SendAsJsonAsync(string text) => throw null;

        public virtual ClientResult GetAsJson(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetAsJsonAsync(RequestOptions options) => throw null;

        public virtual ClientResult<string> GetAsJson() => throw null;

        public virtual Task<ClientResult<string>> GetAsJsonAsync() => throw null;
    }
}
