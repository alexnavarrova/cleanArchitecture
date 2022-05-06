using MediatR;

namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideosListQuery : IRequest<List<VideosVm>>
    {
        public string _Username { get; set; } = String.Empty;
        public GetVideosListQuery(string userName)
        {
            _Username = userName ?? throw new ArgumentNullException(nameof(userName)); 
        }
    }
}
