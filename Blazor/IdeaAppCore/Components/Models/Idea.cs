using System.ComponentModel.DataAnnotations;

namespace IdeaAppCore.Components.Models
{
    public class Idea
    {
        public int Id { get; set; }
        [Required]
        public string Note {  get; set; }

        public interface IIdeaRepository
        {
            Task<Idea> AddIdea(Idea idea);
            Task<List<Idea>> GetIdeas();

        }

        public class IdeaReporitory:IIdeaRepository
        {
            public Task<Idea> AddIdea(Idea idea)
            {
                throw new System.NotImplementedException();
            }
             
            public Task<List<Idea>> GetIdeas()
            {
                throw new System.NotImplementedException();
                
            }
        }
    }
}
