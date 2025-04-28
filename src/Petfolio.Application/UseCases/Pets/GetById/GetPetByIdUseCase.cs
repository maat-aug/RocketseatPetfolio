using Petfolio.Communication.Reponses;

namespace Petfolio.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int Id)
        {
            return new ResponsePetJson 
            { 
                Id = Id,
                Name = "Cacau",
                Type = Communication.Enums.PetType.Dog,
                Birthday = new DateTime(year: 2020, month: 01, day: 01),
            };
        }
    }
}
