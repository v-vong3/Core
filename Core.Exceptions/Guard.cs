using System;
using System.Collections;
using System.IO;

namespace Core.Exceptions
{
    /// <summary>
    /// Static class to provide common argument validation checks that must pass 
    /// prior to moving the flow of control forward
    /// </summary>
    /// <remarks>
    /// For a more intuitive usage of <c>Gurad</c>'s APIs, exceptions are thrown within  
    /// this class's context instead of the caller context.
    /// Consequently, stack traces will originate from here instead of the caller's target site.
    /// 
    /// If you need an outcome that is not a thrown exception upon detection of violation, then this
    /// class should not be used; instead write custom validation code
    /// </remarks>
    public static class Guard
    {
        // DESIGN: Assumes that the legal adult age is 18
        private static int LEGAL_AGE => 18;

        private static string NameGuard(string argumentName)
        {
            return argumentName == null ? string.Empty : $"[{argumentName}]";
        }

        /// <summary>
        /// Guard against null <c>String</c> arguments
        /// </summary>
        /// <param name="argument">Argument of type string</param>
        /// <param name="argumentName">String literal name of argument</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNullArgument(string argument, string argumentName)
        {
            var argName = NameGuard(argumentName);


            if (string.IsNullOrWhiteSpace(argument))
            {
                return new ArgumentNullException($"Parameter {argName} cannot be null, empty or whitespace.");
            }

            return null;
        }

        /// <summary>
        /// Guard against null <c>object</c> arguments
        /// </summary>
        /// <param name="argument">Argument of type object</param>
        /// <param name="argumentName">String literal name of argument</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNullArgument(object argument, string argumentName)
        {
            var argName = NameGuard(argumentName);

            if (argument == null)
            {
                throw new ArgumentNullException($"Parameter [{argumentName}] cannot be null");
            }

            return null;
        }

        public static object AgainstEmptyCollection(ICollection collection, string argumentName)
        {
            Guard.AgainstNullArgument(argumentName, nameof(argumentName));
            Guard.AgainstNullArgument(collection, argumentName);

            if(collection.Count == 0)
            {
                throw new ArgumentException($"Parameter [{argumentName}] must contain at least 1 element.");
            }

            return null;
        }


        public static object AgainstEmptyCollection(object[] collection, string argumentName)
        {
            Guard.AgainstNullArgument(argumentName, nameof(argumentName));
            Guard.AgainstNullArgument(collection, argumentName);

            if (collection.Length == 0)
            {
                throw new ArgumentException($"Parameter [{argumentName}] must contain at least 1 element.");
            }

            return null;
        }




        /// <summary>
        /// Guard against non-existent directories or paths
        /// </summary>
        /// <param name="path">Fully-qualified path (e.g. c:\directory\path)</param>
        /// <param name="argumentName">String literal name of argument</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNonExistentPath(string path, string argumentName)
        {
            Guard.AgainstNullArgument(argumentName, nameof(argumentName));
            Guard.AgainstNullArgument(path, argumentName);

            if(!Directory.Exists(path))
            {
                throw new ArgumentException($"Invalid [{argumentName}] value.  The provided path does not exist.");
            }

            return null;
        }

        /// <summary>
        /// Guard against non-existent files
        /// </summary>
        /// <remarks>
        /// Filenames must include file extension
        /// </remarks>
        /// <param name="filename">Fully-qualified filename (e.g. c:\directory\filename.txt)</param>
        /// <param name="argumentName">String literal name of argument</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNonExistentFile(string filename, string argumentName)
        {
            Guard.AgainstNullArgument(argumentName, nameof(argumentName));
            Guard.AgainstNullArgument(filename, argumentName);

            if (!File.Exists(filename))
            {
                throw new ArgumentException($"Invalid [{argumentName}] value.  The provided file does not exist.");
            }

            return null;
        }

        /// <summary>
        /// Guard against allowing under-age entities
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="argumentName"></param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstMinors(DateTime dateOfBirth, string argumentName)
        {
            Guard.AgainstNullArgument(argumentName, nameof(argumentName));
            Guard.AgainstNullArgument(dateOfBirth, argumentName);

            if(dateOfBirth.Kind == DateTimeKind.Unspecified)
            {
                throw new Exception("Date does not specify that it is UTC or not.  Unable to accurately determine age.");
            }

            if(dateOfBirth.Kind == DateTimeKind.Local)
            {
                // Normalize DOB to UTC
                dateOfBirth = dateOfBirth.ToUniversalTime();
            }

            var isMinor = dateOfBirth < DateTime.UtcNow.AddYears(-18);

            if(isMinor)
            {
                throw new BusinessRuleException("Date of birth belongs to a minor");
            }

            return null;
        }



        
    }
}
