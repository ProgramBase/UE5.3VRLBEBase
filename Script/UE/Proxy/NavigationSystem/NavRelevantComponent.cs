using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavRelevantComponent")]
	public partial class UNavRelevantComponent : UActorComponent, IStaticClass, INavRelevantInterface
	{
		public bool bAttachToOwnersRoot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAttachToOwnersRoot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAttachToOwnersRoot, __InBuffer);
				}
			}
		}

		public UObject CachedNavParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedNavParent, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedNavParent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavRelevantComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetNavigationRelevancy(bool bRelevant)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRelevant;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRelevancy, __InBuffer);
			}
		}

		private static uint __bAttachToOwnersRoot = 0;

		private static uint __CachedNavParent = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetNavigationRelevancy = 0;
	}
}