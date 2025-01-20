static void swap(int[] nums, int l, int i)
{
    int temp = nums[l];
    nums[l] = nums[i];
    nums[i] = temp;
}

static void permutations(List<int[]> res, int[] nums, int l, int h)
{
    if (l == h)
    {
        res.Add((int[])nums.Clone());
        return;
    }

    for (int i = l; i <= h; i++)
    {
        swap(nums, l, i);
        permutations(res, nums, l + 1, h);
        swap(nums, l, i);
    }
}

static List<int[]> permute(int[] nums)
{
    List<int[]> res = new List<int[]>();
    int x = nums.Length - 1;

    permutations(res, nums, 0, x);
    return res;
}

int[] nums = { 1, 2, 3, };
List<int[]> res = permute(nums);

foreach (int[] x in res)
{
    foreach (int y in x)
    {
        Console.WriteLine(y + " ");
    }
    Console.WriteLine();
}