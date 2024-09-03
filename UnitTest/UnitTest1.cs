/******************************************************************************
* Filename    = UnitTest.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = UnitTests
*****************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeTheaterManager;

namespace UnitTests
{
    [TestClass]
    public class HomeTheaterFacadeTests
    {
        private HomeTheaterFacade _facade;
        private MockProjector _mockProjector;
        private MockSoundSystem _mockSoundSystem;
        private MockDVDPlayer _mockDVDPlayer;

        [TestInitialize]
        public void Setup()
        {
            _mockProjector = new MockProjector();
            _mockSoundSystem = new MockSoundSystem();
            _mockDVDPlayer = new MockDVDPlayer();

            _facade = new HomeTheaterFacade(_mockProjector, _mockSoundSystem, _mockDVDPlayer);
        }

        [TestMethod]
        public void WatchMovie_TurnsOnAllComponentsAndPlaysMovie()
        {
            // Arrange
            string movie = "Inception";

            // Act
            _facade.WatchMovie(movie);

            // Assert
            Assert.IsTrue(_mockProjector.IsOn, "Projector should be on");
            Assert.IsTrue(_mockSoundSystem.IsOn, "Sound system should be on");
            Assert.AreEqual(5, _mockSoundSystem.Volume, "Sound system volume should be set to 5");
            Assert.IsTrue(_mockDVDPlayer.IsOn, "DVD player should be on");
            Assert.AreEqual(movie, _mockDVDPlayer.PlayedMovie, "DVD player should be playing the correct movie");
        }

        [TestMethod]
        public void EndMovie_TurnsOffAllComponents()
        {
            // Act
            _facade.EndMovie();

            // Assert
            Assert.IsFalse(_mockDVDPlayer.IsOn, "DVD player should be off");
            Assert.IsFalse(_mockSoundSystem.IsOn, "Sound system should be off");
            Assert.IsFalse(_mockProjector.IsOn, "Projector should be off");
        }
    }

    // Mock classes for testing
    public class MockProjector : Projector
    {
        public bool IsOn { get; private set; }

        public override void On()
        {
            IsOn = true;
        }

        public override void Off()
        {
            IsOn = false;
        }
    }

    public class MockSoundSystem : SoundSystem
    {
        public bool IsOn { get; private set; }
        public int Volume { get; private set; }

        public override void On()
        {
            IsOn = true;
        }

        public override void Off()
        {
            IsOn = false;
        }

        public override void SetVolume(int level)
        {
            Volume = level;
        }
    }

    public class MockDVDPlayer : DVDPlayer
    {
        public bool IsOn { get; private set; }
        public string PlayedMovie { get; private set; }

        public override void On()
        {
            IsOn = true;
        }

        public override void Off()
        {
            IsOn = false;
        }

        public override void Play(string movie)
        {
            PlayedMovie = movie;
        }
    }
}