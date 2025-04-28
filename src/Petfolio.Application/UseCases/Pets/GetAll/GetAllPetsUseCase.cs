using Petfolio.Communication.Reponses;

namespace Petfolio.Application.UseCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
             /*   Pets = new List<ResponseShortPetJson>
                {
                   new ResponseShortPetJson
                   {
                       Id = 1, 
                       Name = "Cacau",
                       Type = Communication.Enums.PetType.Dog,
                   }
                }  */ 
            };

        }
    }
}
