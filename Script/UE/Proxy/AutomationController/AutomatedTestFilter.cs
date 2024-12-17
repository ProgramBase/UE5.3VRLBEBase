using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationController
{
	[PathName("/Script/AutomationController.AutomatedTestFilter")]
	public partial class FAutomatedTestFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AutomationController.AutomatedTestFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutomatedTestFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutomatedTestFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutomatedTestFilter A, FAutomatedTestFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutomatedTestFilter A, FAutomatedTestFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutomatedTestFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Contains
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Contains, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Contains, __InBuffer);
				}
			}
		}

		public bool MatchFromStart
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MatchFromStart, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MatchFromStart, __InBuffer);
				}
			}
		}

		public bool MatchFromEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MatchFromEnd, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MatchFromEnd, __InBuffer);
				}
			}
		}

		private static uint __Contains = 0;

		private static uint __MatchFromStart = 0;

		private static uint __MatchFromEnd = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}