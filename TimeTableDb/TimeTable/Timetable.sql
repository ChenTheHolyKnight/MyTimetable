CREATE TABLE [dbo].[TimeTable]
(
    [Id]    BIGINT          NOT NULL,
    [CourseName]  NCHAR(10)   NOT NULL
    /*
     *  Tweet text size is 1000 because we can no longer assume that it will be 140 characters.
     *  https://github.com/linvi/tweetinvi/wiki/Extended-Tweets-&-TweetMode
     */

    CONSTRAINT [PK_Subscription] PRIMARY KEY CLUSTERED ([Id] ASC), 
    [CourseLocation] NCHAR(10) NOT NULL, 
    [CourseTime] NCHAR(1000) NOT NULL
)
