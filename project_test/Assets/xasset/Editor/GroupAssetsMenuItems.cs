using UnityEngine;
using UnityEditor;
namespace xasset.editor
{
	public static class GroupAssetsMenuItems
	{
		[MenuItem("Assets/Group To/MyBuilder/UpdatePanel")]
		private static void GroupToMyBuilderUpdatePanel()
		{
			Settings.MakeSelectionAssetsGroupTo("MyBuilder", "UpdatePanel");
			Debug.Log("Group to UpdatePanel with build MyBuilder.");
		}

		[MenuItem("Assets/Group To/MyBuilder/Scenes")]
		private static void GroupToMyBuilderScenes()
		{
			Settings.MakeSelectionAssetsGroupTo("MyBuilder", "Scenes");
			Debug.Log("Group to Scenes with build MyBuilder.");
		}

		[MenuItem("Assets/Group To/MyBuilder/Prefabs")]
		private static void GroupToMyBuilderPrefabs()
		{
			Settings.MakeSelectionAssetsGroupTo("MyBuilder", "Prefabs");
			Debug.Log("Group to Prefabs with build MyBuilder.");
		}
	}
}
