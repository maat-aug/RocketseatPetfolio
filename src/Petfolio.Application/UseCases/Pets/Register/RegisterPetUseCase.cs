using Petfolio.Communication.Reponses;
using Petfolio.Communication.Requests;

namespace Petfolio.Application.UseCases.Pets.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisteredPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisteredPetJson
            {
                Id = 6,
                Name = request.Name,
            };
        }
    }
}
