def getModeMedian(list_1):
    median=0
    mode=0
    n = len(list_1)
    for i in range(n-1,-1,-1): #liste sıralandı. best case n, worst case n**2
        for j in range(0,i):
            if not(list_1[j]<list_1[j+1]):
                temp=list_1[j]
                list_1[j]=list_1[j+1]
                list_1[j+1]=temp
 # medyan bulurken bir döngü yok.tek hesaplama var.bu yüzden n kadar kod karmaşıklığa etki etmez.
 # fakat öncesinde bir sıralama şart. bu yüzden bubble sort ile best case n, worst case n**2 etkisi mevcut.
    if n % 2 == 0:
        median1 = list_1[n // 2]
        median2 = list_1[n // 2 - 1]
        median = (median1 + median2) / 2
    else:
        median = list_1[n // 2]

 #mod hesaplanırken liste sıralamasına gerek yok. o yüzden bubble sort etki etmez.
 #frekanslara ve bu frekansların en yükseğine ihtiyacımız var.
    frequency_list=[]
    for i in range(len(list_1)):
        s=False
        for j in range(len(frequency_list)):
            if (list_1[i]==frequency_list[j][0]):
                frequency_list[j][1]=frequency_list[j][1]+1
                s=True
                if(s==False):
                    frequency_list.append([list_1[i],1])
    maks=0
    for k in range (len(frequency_list)): # frekans listesinde maksimum frekansı arıyoruz.
# frekansların tespiti için worst case n**2 ile birlikte burada da bir n lik döngü ile birlikte n**2+n oldu
        if(frequency_list[k][1] > maks):
            maks=frequency_list[k][1]
            mode=frequency_list[k][0]

    return median,mode


