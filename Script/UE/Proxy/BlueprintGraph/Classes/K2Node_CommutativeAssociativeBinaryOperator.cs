﻿using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_CommutativeAssociativeBinaryOperator")]
	public partial class UK2Node_CommutativeAssociativeBinaryOperator : UK2Node_CallFunction, IStaticClass, IK2Node_AddPinInterface
	{
		public int NumAdditionalInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumAdditionalInputs, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumAdditionalInputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_CommutativeAssociativeBinaryOperator");
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

		private static uint __NumAdditionalInputs = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}