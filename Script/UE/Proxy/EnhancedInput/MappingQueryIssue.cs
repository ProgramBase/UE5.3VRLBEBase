using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.MappingQueryIssue")]
	public partial class FMappingQueryIssue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.MappingQueryIssue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMappingQueryIssue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMappingQueryIssue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMappingQueryIssue A, FMappingQueryIssue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMappingQueryIssue A, FMappingQueryIssue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMappingQueryIssue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EMappingQueryIssue Issue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Issue, __ReturnBuffer);

					return *(EMappingQueryIssue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Issue, __InBuffer);
				}
			}
		}

		public UInputMappingContext BlockingContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlockingContext, __ReturnBuffer);

					return *(UInputMappingContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlockingContext, __InBuffer);
				}
			}
		}

		public UInputAction BlockingAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlockingAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlockingAction, __InBuffer);
				}
			}
		}

		private static uint __Issue = 0;

		private static uint __BlockingContext = 0;

		private static uint __BlockingAction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}