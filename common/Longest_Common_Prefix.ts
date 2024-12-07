export function longestCommonPrefix(data: string[]): string {
    if (!data[0] || data.length == 1) return data[0] || "";
    let i = 0;
    while (data[0][i] && data.every(w => w[i] === data[0][i]))
        i++;

    return data[0].slice(0, i);
}