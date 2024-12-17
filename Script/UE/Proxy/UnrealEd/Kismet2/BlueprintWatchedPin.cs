using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlueprintWatchedPin")]
	public partial class FBlueprintWatchedPin : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.BlueprintWatchedPin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintWatchedPin() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintWatchedPin() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintWatchedPin A, FBlueprintWatchedPin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintWatchedPin A, FBlueprintWatchedPin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintWatchedPin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UEdGraphNode> OwningNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwningNode, __ReturnBuffer);

					return *(TSoftObjectPtr<UEdGraphNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwningNode, __InBuffer);
				}
			}
		}

		public FGuid PinId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PinId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PinId, __InBuffer);
				}
			}
		}

		public TArray<FName> PathToProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathToProperty, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathToProperty, __InBuffer);
				}
			}
		}

		private static uint __OwningNode = 0;

		private static uint __PinId = 0;

		private static uint __PathToProperty = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}