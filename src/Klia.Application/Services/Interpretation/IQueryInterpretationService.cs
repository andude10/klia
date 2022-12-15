using Klia.Application.Common.Models;

namespace Klia.Application.Services.Interpretation;

public interface IQueryInterpretationService
{
    public Query Parse(string text);
}