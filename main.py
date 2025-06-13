def main():
    urun_sayisi = 15
    toplam_fiyat = 0

    for i in range(1, urun_sayisi + 1):
        while True:
            try:
                fiyat = float(input(f"Ürün {i} fiyatını girin: "))
                if fiyat < 0:
                    raise ValueError
                break
            except ValueError:
                print("Geçerli bir pozitif sayı girin.")
        
        toplam_fiyat += fiyat

    ortalama = toplam_fiyat / urun_sayisi
    print(f"\n15 ürünün ortalama fiyatı: {ortalama:.2f} TL")

if __name__ == "__main__":
    main()
