using shop.Application.Common;
using shop.Application.ViewModels.Colors;
using shop.Application.ViewModels.Colors.Queries;
using shop.Application.ViewModels.Colors.Requests;

namespace shop.Application.Interfaces;

public interface IColorServices
{
    Task<ApiResponse<List<ColorDto>>> GetAllColors();
    Task<ApiResponse<ColorDto>> GetColorById(ColorGetByIdRequest request);
    Task<ApiResponse<bool>> CreateColor(ColorCreateRequest request);
    Task<ApiResponse<bool>> UpdateColor(Guid ID,ColorUpdateRequest request);
    Task<ApiResponse<bool>> DeleteColor(ColorDeleteRequest request);
}