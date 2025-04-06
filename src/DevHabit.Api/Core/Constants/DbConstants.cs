namespace DevHabit.Api.Core.Constants;

public sealed class DbConstants
{
    // string constants
    public const int VARCHAR_STRING_LENGTH_2 = 2;
    public const int VARCHAR_STRING_LENGTH_5 = 5;
    public const int VARCHAR_STRING_LENGTH_10 = 10;
    public const int VARCHAR_STRING_LENGTH_15 = 15;
    public const int VARCHAR_STRING_LENGTH_25 = 25;
    public const int VARCHAR_STRING_LENGTH_35 = 35;
    public const int VARCHAR_STRING_LENGTH_50 = 50;
    public const int VARCHAR_STRING_LENGTH_100 = 100;
    public const int VARCHAR_STRING_LENGTH_150 = 150;
    public const int VARCHAR_STRING_LENGTH_255 = 255;
    public const int VARCHAR_STRING_LENGTH_500 = 500;
    public const int VARCHAR_STRING_LENGTH_1024 = 1024;
    public const int VARCHAR_STRING_LENGTH_2048 = 2048;

    public const int INTEGER_LENGTH_500 = 500;

    // int constants
    public const int VERSION_DEFAULT_VALUE = 1;
    public const int MAX_FAILED_LOGIN_ATTEMPTS = 3;
    public const int DEFAULT_FAILED_LOGIN_ATTEMPTS = 0;
    public const bool DEFAULT_IS_DELETED = false;
    public const bool DEFAULT_IS_ONLINE = false;
    public const bool DEFAULT_IS_REVOKED = false;
    public const bool DEFAULT_IS_BLOCKED = false;
    public const bool DEFAULT_IS_SAVED_N_CONFIRMED = false;
    public const bool DEFAULT_IS_PUBLISHED = false;
    public const bool DEFAULT_IS_STOPPED = false;
    public const bool DEFAULT_IS_STARTED = false;
    public const bool DEFAULT_IS_PENDING = true;
    public const bool DEFAULT_IS_FASLE = false;
    public const bool DEFAULT_IS_TRUE = true;

    // default languages
    public const string DEFAULT_ENGLISH_LANGUAGE = "en";
    public const string DEFAULT_ARABIC_LANGUAGE = "er";

    //date time constants
    public const string CURRENT_TIMESTAMP = "CURRENT_TIMESTAMP(6)";

}
