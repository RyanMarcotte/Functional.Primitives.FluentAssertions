﻿using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Functional.Unions.FluentAssertions.Tests
{
	public partial class UnionValueTypeAssertionsTests
	{
		public class TaskDefinitionWithSixTypes
		{
			[Fact]
			public void When_EqualityIsTrue_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelSix)).Value().Should().Be(Union.FromDefinition<SixDefinition>().Create(ModelSix).Value())
			).Should().NotThrow();

			[Fact]
			public void When_EqualityIsFalse_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelSix)).Value().Should().Be(Union.FromDefinition<SixDefinition>().Create(new ClassSix()).Value())
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsOne_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelOne)).Value().Should().BeOfTypeOne()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsNotOne_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelOne)).Value().Should().BeOfTypeTwo()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsTwo_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelTwo)).Value().Should().BeOfTypeTwo()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsNotTwo_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelTwo)).Value().Should().BeOfTypeOne()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsThreeAndExpectedTypeIsThree_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelThree)).Value().Should().BeOfTypeThree()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsThreeAndExpectedTypeIsNotThree_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelThree)).Value().Should().BeOfTypeTwo()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsFourAndExpectedTypeIsFour_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFour)).Value().Should().BeOfTypeFour()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFourAndExpectedTypeIsNotFour_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFour)).Value().Should().BeOfTypeThree()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsFiveAndExpectedTypeIsFive_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFive)).Value().Should().BeOfTypeFive()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFiveAndExpectedTypeIsNotFive_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFive)).Value().Should().BeOfTypeFour()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsSixAndExpectedTypeIsSix_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelSix)).Value().Should().BeOfTypeSix()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSixAndExpectedTypeIsNotSix_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelSix)).Value().Should().BeOfTypeFive()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelOne)).Value().Should().BeOfTypeOne().AndValue(value => value.Should().Be(ModelOne))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelTwo)).Value().Should().BeOfTypeTwo().AndValue(value => value.Should().Be(ModelTwo))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsThreeAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelThree)).Value().Should().BeOfTypeThree().AndValue(value => value.Should().Be(ModelThree))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFourAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFour)).Value().Should().BeOfTypeFour().AndValue(value => value.Should().Be(ModelFour))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFiveAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelFive)).Value().Should().BeOfTypeFive().AndValue(value => value.Should().Be(ModelFive))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSixAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromDefinition<SixDefinition>().Create(ModelSix)).Value().Should().BeOfTypeSix().AndValue(value => value.Should().Be(ModelSix))
			).Should().NotThrow();
		}
	}
}
