﻿using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioMultiEnvelopeValue__PythonCallable.OnAudioMultiEnvelopeValue__PythonCallable")]
	public partial class OnAudioMultiEnvelopeValue__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioMultiEnvelopeValue__PythonCallable.OnAudioMultiEnvelopeValue__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}