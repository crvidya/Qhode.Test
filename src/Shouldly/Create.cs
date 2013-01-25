﻿using Rhino.Mocks;

namespace Shouldly
{
    public static class Create
    {
        public static T Mock<T>() where T : class
        {
            return MockRepository.GenerateMock<T>();
        }

        public static T Stub<T>() where T : class
        {
            return MockRepository.GenerateStub<T>();
        }

        public static T Partial<T>(params object[] constructorArgs) where T : class
        {
            return new MockRepository().PartialMock<T>(constructorArgs);
        }
    }
}