using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.PhasedAutomationActorBase")]
	public partial class APhasedAutomationActorBase : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.PhasedAutomationActorBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnFunctionalTestingComplete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnFunctionalTestingComplete);
			}
		}

		public virtual void OnFunctionalTestingBegin()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnFunctionalTestingBegin);
			}
		}

		private static uint __OnFunctionalTestingComplete = 0;

		private static uint __OnFunctionalTestingBegin = 0;
	}
}