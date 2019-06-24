# Hướng dẫn ngôn ngữ C# - Buổi 03

## 1. Câu lệnh điều kiện (rẻ nhánh)

### 1.1 Câu lệnh IF ... ELESE

```c#
if(điều kiện)
{
    // Khối lệnh nếu điều kiện đúng
}
else 
{
    // Khối lệnh nếu điều kiện sai
}
```

### 1.2 Câu lệnh SWITCH ... CASE

```c#
switch(biến dò)
{
    case "giá trị 1":
        // Khối lệnh
        break;

    case "giá trị 2":
        // Khối lệnh
        break;

    case "giá trị 3":
        // Khối lệnh
        break;

    default:
        // Khối lệnh
}
```

## 2. Vòng lặp

### 2.1 Vòng lặp FOR ...

```c#
for(Khởi gián giá trị bắt đầu; điều kiện lặp; bước nhảy)
{
    // Khối lệnh xử lý
}
```

Ví dụ:

```c#
for(int i = 0; i < 10; i++)
{
    Console.Write(i);
}
```

### 2.2 Vòng lặp WHILE ...

```c#
while (Điều kiện)
{
    // Khối lệnh xử lý khi điều kiện đúng
}
```

*Khi điều kiện đúng thì mới làm*

### 2.3 Vòng lặp DO ... WHILE ... 

```c#
do
{
    // Khối lệnh xử lý
} while (điều kiện);
```

*Làm, khi điều kiện đúng thì làm tiếp*

### 2.4 Vòng lặp FOR EACH ... dùng cho duyệt tất cả các phần tử của mảng

```c#
int[] a = {1, 2, 3, 4, 5};
for each (int i in a)
{
    Console.Write(i);
}
```

Khối lệnh trên tương đương với vòng lặp for sau

```c#
int[] a = {1, 2, 3, 4, 5};
for(int i = 0; i < a.Length; i++)
{
    Console.Write(a[i]);
}
```

*Chỉ sử dụng khi duyệt hết tất cả các phần tử của mảng, đi từ đầu mảng đến cuối mảng*

## 3. Hàm Function

```c#
public static <Kiểu dữ liệu trả về> Tên_Hàm(Danh sách tham số)
{
    // Khối lệnh xử lý
    return ....
}
```

ví dụ:
```c#
public static int CongHaiSo(int a, int b)
{
    return a + b;
}

public static void InKetQua(int a)
{
    Console.Write(a);
}

// Truyền chiếu
public static void HoanVi(ref int a, ref int b)
{
    int c = a;
    a = b; 
    b = c
}

// Kết quả sau khi gọi hàm HoanVi thì a và b sẽ phải đổi giá trị cho nhau
int a = 10; 
int b = 30;
HoanVi(a, b); // a = 30 và b = 10
```