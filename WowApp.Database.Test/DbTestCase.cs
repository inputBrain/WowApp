using System;

namespace WowApp.Database.Test
{
    public class DbTestCase : IDisposable
    {
        internal Fixture Fixture => _fixture ??= Fixture.Create();
        private Fixture _fixture;

        internal DatabaseContainer DatabaseContainer => Fixture.DatabaseContainer;


        public void Dispose()
        {
            _fixture?.Dispose();
        }
    }
}