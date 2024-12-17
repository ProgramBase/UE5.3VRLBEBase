using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDynamicBinding")]
	public partial class FMovieSceneDynamicBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneDynamicBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneDynamicBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneDynamicBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneDynamicBinding A, FMovieSceneDynamicBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneDynamicBinding A, FMovieSceneDynamicBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneDynamicBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UFunction Function
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Function, __ReturnBuffer);

					return *(UFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Function, __InBuffer);
				}
			}
		}

		public TFieldPath<FProperty> ResolveParamsProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResolveParamsProperty, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResolveParamsProperty, __InBuffer);
				}
			}
		}

		public TMap<FName, FMovieSceneDynamicBindingPayloadVariable> PayloadVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PayloadVariables, __ReturnBuffer);

					return *(TMap<FName, FMovieSceneDynamicBindingPayloadVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PayloadVariables, __InBuffer);
				}
			}
		}

		public FName CompiledFunctionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompiledFunctionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompiledFunctionName, __InBuffer);
				}
			}
		}

		public FName ResolveParamsPinName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResolveParamsPinName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResolveParamsPinName, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UObject> WeakEndpoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeakEndpoint, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeakEndpoint, __InBuffer);
				}
			}
		}

		private static uint __Function = 0;

		private static uint __ResolveParamsProperty = 0;

		private static uint __PayloadVariables = 0;

		private static uint __CompiledFunctionName = 0;

		private static uint __ResolveParamsPinName = 0;

		private static uint __WeakEndpoint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}