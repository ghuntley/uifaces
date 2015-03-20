using System.Threading.Tasks;
using Refit;

namespace UIFaces
{
    public interface IUIFaceApi
    {
        [Get("/v1/random")]
        Task<Face> Random();

        [Get("/v1/user/{username}")]
        Task<Face> GetUsername(string username);
    }
}