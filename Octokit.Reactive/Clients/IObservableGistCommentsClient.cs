﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;

namespace Octokit.Reactive
{
    public interface IObservableGistCommentsClient
    {
        /// <summary>
        /// Gets a single comment by gist- and comment id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#get-a-single-comment</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <param name="commentId">The id of the comment</param>
        /// <returns>IObservable{GistComment}.</returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
            Justification = "Method makes a network request")]
        IObservable<GistComment> Get(string gistId, long commentId);

        /// <summary>
        /// Gets all comments for the gist with the specified id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#list-comments-on-a-gist</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <returns>IObservable{GistComment}.</returns>
        IObservable<GistComment> GetAllForGist(string gistId);

        /// <summary>
        /// Gets all comments for the gist with the specified id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#list-comments-on-a-gist</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns>IObservable{GistComment}.</returns>
        IObservable<GistComment> GetAllForGist(string gistId, ApiOptions options);

        /// <summary>
        /// Creates a comment for the gist with the specified id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#create-a-comment</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <param name="comment">The body of the comment</param>
        /// <returns>IObservable{GistComment}.</returns>
        IObservable<GistComment> Create(string gistId, string comment);

        /// <summary>
        /// Updates the comment with the specified gist- and comment id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#edit-a-comment</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <param name="commentId">The id of the comment</param>
        /// <param name="comment">The updated body of the comment</param>
        /// <returns>IObservable{GistComment}.</returns>
        IObservable<GistComment> Update(string gistId, long commentId, string comment);

        /// <summary>
        /// Deletes the comment with the specified gist- and comment id.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/gists/comments/#delete-a-comment</remarks>
        /// <param name="gistId">The id of the gist</param>
        /// <param name="commentId">The id of the comment</param>
        /// <returns>IObservable{Unit}.</returns>
        IObservable<Unit> Delete(string gistId, long commentId);
    }
}