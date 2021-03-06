﻿using Functional.Unions.FluentAssertions;
using System;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace (ease of discoverability)
namespace Functional
{
	/// <summary>
	/// Extension methods for the <see cref="AndUnionValueConstraint{T}"/> class.
	/// </summary>
	public static class AndUnionValueConstraintExtensions
	{
		/// <summary>
		/// Returns the value of the union to perform additional assertions on.
		/// </summary>
		/// <typeparam name="TValue">The type of the contained value.</typeparam>
		/// <param name="source">The source <see cref="AndUnionValueConstraint{TValue}"/></param>
		/// <param name="action">Action containing the additional assertions to perform on the contained value.</param>
		/// <returns></returns>
		public static async Task AndValue<TValue>(this Task<AndUnionValueConstraint<TValue>> source, Action<TValue> action)
			=> action((await source).AndValue);
	}
}
