using System;
using System.Collections;
using System.Collections.Generic;
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

        private static string FormatName(string name)
        {
            return name == null ? string.Empty : $"[{name}]";
        }

        /// <summary>
        /// Guard against null <c>String</c> arguments
        /// </summary>
        /// <param name="argument">Argument of type string</param>
        /// <param name="argumentName">String literal name of argument</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNullArgument(string argument, string argumentName)
        {
            var argName = FormatName(argumentName);


            if (string.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentNullException($"Parameter {argName} cannot be null, empty or whitespace.");
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
            var argName = FormatName(argumentName);

            if (argument == null)
            {
                throw new ArgumentNullException($"Parameter {argumentName} cannot be null");
            }

            return null;
        }

        /// <summary>
        /// Guard against null <c>String</c> variables
        /// </summary>
        /// <param name="variable">Variable of type string</param>
        /// <param name="variableName">String literal name of variable</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNullVariable(string variable, string variableName)
        {
            var name = FormatName(variableName);

            if (string.IsNullOrWhiteSpace(variable))
            {
                throw new Exception($"{name} cannot be null, empty or whitespace");
            }

            return null;
        }

        /// <summary>
        /// Guard against null <c>object</c> variables
        /// </summary>
        /// <param name="variable"></param>
        /// <param name="variableName"></param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstNullVariable(object variable, string variableName)
        {
            var name = FormatName(variableName);

            if (variable == null)
            {
                throw new NullReferenceException($"{name} cannot be null");
            }

            return null;
        }


        /// <summary>
        /// Guard against null <c>ICollection</c> objects
        /// </summary>
        /// <param name="collection">A <c>ICollection</c> object</param>
        /// <param name="variableName">String literal name of variable</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstEmptyCollection(ICollection collection, string variableName)
        {
            Guard.AgainstNullVariable(variableName, nameof(variableName));
            Guard.AgainstNullVariable(collection, variableName);

            var name = FormatName(variableName);

            if (collection.Count == 0)
            {
                throw new Exception($"{name} must contain at least 1 element");
            }

            return null;
        }

        /// <summary>
        /// Guard against null <c>ICollection<T></c> objects
        /// </summary>
        /// <param name="collection">A <c>ICollection</c> object</param>
        /// <param name="variableName">String literal name of variable</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstEmptyCollection<T>(ICollection<T> collection, string variableName)
        {
            Guard.AgainstNullVariable(variableName, nameof(variableName));
            Guard.AgainstNullVariable(collection, variableName);

            var name = FormatName(variableName);

            if (collection.Count == 0)
            {
                throw new Exception($"{name} must contain at least 1 element");
            }

            return null;
        }

        /// <summary>
        /// Guard against empty array variables by throwing appropriate exceptions
        /// </summary>
        /// <param name="array">An <c>Array</c> variable</param>
        /// <param name="variableName">String literal name of variable</param>
        /// <returns>Throws appropriate exception if invalid, return null otherwise</returns>
        public static object AgainstEmptyCollection(object[] array, string variableName)
        {
            Guard.AgainstNullVariable(variableName, nameof(variableName));
            Guard.AgainstNullVariable(array, variableName);

            var name = FormatName(variableName);

            if (array.Length == 0)
            {
                throw new Exception($"{name} must contain at least 1 element.");
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

            var argName = FormatName(argumentName);

            if (!Directory.Exists(path))
            {
                throw new IOException($"Invalid {argName} value.  The provided path does not exist.");
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

            var argName = FormatName(argumentName);

            if (!File.Exists(filename))
            {
                throw new IOException($"Invalid {argName} value.  The provided file does not exist.");
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

            var argName = FormatName(argumentName);

            if (dateOfBirth.Kind == DateTimeKind.Unspecified)
            {
                throw new Exception($"{argName} does not specify that it is UTC or not.  Unable to accurately determine age.");
            }

            if (dateOfBirth.Kind == DateTimeKind.Local)
            {
                // Normalize DOB to UTC
                dateOfBirth = dateOfBirth.ToUniversalTime();
            }

            var minimumDate = DateTime.UtcNow.AddYears(LEGAL_AGE * -1);

            var isMinor = dateOfBirth > minimumDate;

            if (isMinor)
            {
                throw new BusinessRuleException("Date of birth belongs to a minor");
            }

            return null;
        }




    }
}
