using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// A class that represents a modification structure.
    /// </summary>
    /// <typeparam name="T">The type of the modified element.</typeparam>
    [PublicAPI]
    public class Modification<T>
        : IPropagatePropertyAccessPath
    {
        /// <summary>
        /// The old value of the element.
        /// </summary>
        [Required]
        [JsonPropertyName("old")]
        public T Old { get; set; } = default!;
        
        /// <summary>
        /// The new value of the element.
        /// </summary>
        [Required]
        [JsonPropertyName("new")]
        public T New { get; set; } = default!;

        /// <inheritdoc />
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Old)}()", validateHasBeenSet, Old);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(New)}()", validateHasBeenSet, New);
        }
    }
}