import sys

def find_largest_product(numbers, adj=4):
    '''
    find the largest product of adjecent numbers in a sequence of numbers.
    '''
    if adj <= 0:
        raise ValueError('The number should be a non-negative integer and above zero.')

    k = 0 # var for holding which iteration calculated the largest product
    n = 0 # var for moving the sequence along 
    largest_product = 0
    product = 1

    print('no. of digits: ', len(numbers))
    print('adj: ', adj)

    # Algorithm
    while (n < len(numbers) - (adj - 1)):
        print(f'\nn = {n}')
        for i in range(n, n+adj):
            product *= int(numbers[i])
            print(f'index number product  ::  {i}  {numbers[i]}  {product}')
        if product > largest_product:
            largest_product = product
            k = n

        product = 1
        n += 1
        

    print(f'\nlargest product is: {largest_product}, calculated in n = {k}')



def main():
    n = input('Number: ')
    a = int(input('How many adjecent numbers to calculate: '))

    find_largest_product(n, a)



if __name__ == "__main__":
    main()


