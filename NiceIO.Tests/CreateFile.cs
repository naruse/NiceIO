﻿using System;
using NUnit.Framework;

namespace NiceIO.Tests
{
	[TestFixture]
	public class CreateFile : TestWithTempDir
	{
		[Test]
		public void SimpleCase()
		{
			Assert.IsTrue(_tempPath.Combine("myfile").CreateFile().FileExists());
		}

		[Test]
		public void InNonExistingDirectory()
		{
			_tempPath.Combine("not_yet_existing_dir/myotherdir/myfile").CreateFile().FileExists();
		}

		[Test]
		public void OnRelativePath()
		{
			Assert.Throws<InvalidOperationException>(() => new Path("mydir/myfile.txt").CreateFile());
		}
	}
}