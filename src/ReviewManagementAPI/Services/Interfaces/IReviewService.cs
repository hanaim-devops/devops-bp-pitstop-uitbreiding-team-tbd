using System.Collections.Generic;
using ReviewManagementAPI.Commands;
using ReviewManagementAPI.Models;

namespace ReviewManagementAPI.Services.Interfaces;

public interface IReviewService
{
    Review AddReview(CreateReview command);
    List<Review> GetAllReviews();
    Review GetReviewById(string id);
    Review UpdateReview(string id, UpdateReview command);

    void DeleteReview(string reviewId);
    
}